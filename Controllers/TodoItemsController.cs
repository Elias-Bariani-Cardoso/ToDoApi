using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Dapper;
using TodoApi.Models;

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoItemsController : ControllerBase
{
    private readonly string _connectionString = "Data Source=meubanco.db";

    // GET: api/TodoItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItemDTO>>> GetTodoItems()
    {

        using var connection = new SqliteConnection(_connectionString);

        var sql = @"SELECT * FROM TodoItems";

        var items = await connection.QueryAsync<TodoItem>(sql);

        return items.Select(ItemToDTO).ToList();

    }

    // GET: api/TodoItems/5
    // <snippet_GetByID>
    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItemDTO>> GetTodoItem(long id)
    {
        using var connection = new SqliteConnection(_connectionString);

        var sql = @"SELECT * FROM TodoItems WHERE Id = @Id" ;

        var item = await connection.QueryFirstOrDefaultAsync<TodoItem>(sql, new{ Id = id});

        if (item == null)
        {
        return NotFound();
        }

        return ItemToDTO(item);
    }
    // </snippet_GetByID>

    // PUT: api/TodoItems/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Update>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodoItem(long id, TodoItemDTO todoDTO)
    {
        if (id != todoDTO.Id)
            return BadRequest();

        using var connection = new SqliteConnection(_connectionString);
        var affected = await connection.ExecuteAsync(
            "UPDATE TodoItems SET Name = @Name, IsComplete = @IsComplete WHERE Id = @Id",
            new { todoDTO.Name, todoDTO.IsComplete, todoDTO.Id });

        if (affected == 0)
            return NotFound();

        return NoContent();
    }
    // </snippet_Update>

    // POST: api/TodoItems
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Create>
    [HttpPost]
    public async Task<ActionResult<TodoItemDTO>> PostTodoItem(TodoItemDTO todoDTO)
    {
        using var connection = new SqliteConnection(_connectionString);

        var sql = @"INSERT INTO TodoItems(Name, IsComplete)
         VALUES(@Name, @IsComplete);
         SELECT last_insert_rowid();";

        var id = await connection.ExecuteScalarAsync<long>(sql, new { todoDTO.Name, todoDTO.IsComplete });

        todoDTO.Id = id;

        return CreatedAtAction(nameof(GetTodoItem), new { id }, todoDTO);
    }
    // </snippet_Create>

    // DELETE: api/TodoItems/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoItem(long id)
    {
        using var connection = new SqliteConnection(_connectionString);

        var sql = @"DELETE FROM TodoItems WHERE Id = @Id";

        var affected = await connection.ExecuteAsync(sql, new { Id = id });

        if (affected == 0)
            return NotFound();
            
        return NoContent();
    }

    private static TodoItemDTO ItemToDTO(TodoItem todoItem) =>
        new TodoItemDTO
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
        };
}