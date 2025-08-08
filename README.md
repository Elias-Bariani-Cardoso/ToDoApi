# TodoApi

Este projeto é uma API Web simples criada com ASP.NET Core, utilizando o padrão baseado em controladores.

O desenvolvimento seguiu o tutorial oficial da Microsoft:

📚 Tutorial: Criar uma API Web baseada em controlador com ASP.NET Core  
Autores: Tim Deschryver e Rick Anderson  
Data: 02/04/2025  
🔗 [Link para o tutorial](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code)

## 🎯 Objetivo  
Este projeto foi desenvolvido como um exercício prático para aprimorar minha compreensão de C# e da plataforma .NET, com foco em:

- Criação de APIs RESTful usando ASP.NET Core  
- Estruturação de um projeto com boas práticas  
- Uso de Entity Framework Core para persistência de dados  
- Utilização do scaffolding com dotnet-aspnet-codegenerator

---

## Evolução do projeto

Após a fase inicial utilizando Entity Framework Core com banco em memória, o projeto foi refatorado para:

- Substituir EF Core por SQLite como banco de dados leve e persistente localmente  
- Utilizar Dapper, uma micro-ORM simples e performática, para operações CRUD com SQL direto  
- Criar e configurar a tabela SQLite diretamente no `Program.cs`  
- Adaptar os controllers para usar SQLite com Dapper, eliminando a dependência do DbContext  
- Implementar CRUD completo (`GET`, `POST`, `PUT`, `DELETE`) com consultas SQL e Dapper  
- Manter documentação via Swagger/OpenAPI para testes interativos  

---

## 🚀 Como executar o projeto

✅ Pré-requisitos  
- .NET 9 SDK  
- Um editor como Visual Studio Code (opcional)  
- PowerShell, CMD ou terminal Bash

⚙️ Configuração e execução  
Clonar o repositório:

git clone https://github.com/seu-usuario/TodoApi.git
cd TodoApi


2. **Restaurar dependências e compilar**:

    dotnet restore
    dotnet build

3. **Executar a aplicação**:

    dotnet run --launch-profile https

    A aplicação estará disponível em:
    https://localhost:<porta>

    Substitua <porta> pela porta exibida no terminal (normalmente 5001 ou 7139).

4. **Testar os endpoints**:

    Acesse via navegador, Swagger (https://localhost:<porta>/swagger) ou ferramenta como Postman/Insomnia:

### 📦 Stack Tecnológica

**Principais pacotes NuGet**

- Microsoft.AspNetCore.App (metapackage incluído no SDK)
- Microsoft.Data.Sqlite
- Dapper

**Ferramentas CLI**

- dotnet-aspnet-codegenerator (scaffolding)
- Entity Framework Core Tools


### 🧠 Conhecimentos adquiridos
 
- Desenvolvimento Backend com ASP.NET Core
- Criação de controllers via scaffolding
- Configuração de serviços no Program.cs
- Mapeamento de rotas convencionais
- Injeção de dependência
- Persistência de Dados
- Configuração básica do DbContext
- Operações CRUD com Entity Framework Core
- Migrations simples

**Ferramentas**
-CLI do .NET (restore, build, run)
-Gerenciamento de pacotes NuGet
-Geração de código com dotnet-aspnet-codegenerator

### 📌 Considerações importantes


Propósito educacional: Este projeto foi criado exclusivamente para fins de aprendizado.

**Limitações**: 

Não inclui:
📌 Considerações importantes
Propósito educacional: Este projeto foi criado exclusivamente para fins de aprendizado.

Limitações:
- Não inclui autenticação ou autorização
- Não possui validação robusta de dados
- Não implementa tratamento avançado de erros
- Não possui testes automatizados
- Banco de dados SQLite local simples, sem migrações sofisticadas

**Banco de dados**: 
    Utiliza um banco em memória para simplificar a execução.