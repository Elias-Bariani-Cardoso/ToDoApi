# TodoApi

Este projeto é uma API Web simples criada com ASP.NET Core, utilizando o padrão baseado em controladores.

O desenvolvimento seguiu o tutorial oficial da Microsoft:

📚 **Tutorial: Criar uma API Web baseada em controlador com ASP.NET Core**  
Autores: *Tim Deschryver* e *Rick Anderson*  
Data: 02/04/2025  
🔗 [Link para o tutorial](https://learn.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code)

## 🎯 Objetivo

Este projeto foi desenvolvido como um **exercício prático para aprimorar minha compreensão de C# e da plataforma .NET**, com foco em:

- Criação de APIs RESTful usando ASP.NET Core
- Estruturação de um projeto com boas práticas
- Uso de Entity Framework Core para persistência de dados
- Utilização do scaffolding com dotnet-aspnet-codegenerator

---

## 🚀 Como executar o projeto

### ✅ Pré-requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Um editor como [Visual Studio Code](https://code.visualstudio.com/) (opcional)
- PowerShell, CMD ou terminal Bash

---

### ⚙️ Configuração e execução

1. **Clonar o repositório**:

   ```bash
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
- Microsoft.EntityFrameworkCore (v9.0.0)
- Microsoft.EntityFrameworkCore.SqlServer (v9.0.0)
- Microsoft.VisualStudio.Web.CodeGeneration.Design (v9.0.0)

**Ferramentas CLI**

- dotnet-aspnet-codegenerator (scaffolding)
- Entity Framework Core Tools


### 🧠 Conhecimentos adquiridos
 
- Desenvolvimento Backend
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
- Autenticação/autorização
- Validação robusta de dados
- Tratamento avançado de erros
- Testes automatizados

**Banco de dados**: 
    Utiliza um banco em memória para simplificar a execução.