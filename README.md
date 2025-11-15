# EduConnect‑API

API REST para o **EduConnect**, um sistema para conectar estudantes,
professores e instituições de ensino.\
Desenvolvida em **C# / ASP.NET Core**, esta API fornece endpoints para
gerenciar usuários, cursos, turmas, atividades e recursos educacionais.

------------------------------------------------------------------------

## 💡 Funcionalidades Principais

------------------------------------------------------------------------

## 🧱 Arquitetura do Projeto

    EduConnect‑API/
    ├── Controllers/         # Endpoints da API
    ├── Models/              # Modelos de domínio (DTOs, entidades)
    ├── Services/            # Lógica de negócio
    ├── Data/                 # Contexto do banco de dados, migrations
    ├── Migrations/           # Migrations EF Core
    ├── EduConnect‑API.slnx   # Solução .NET
    ├── appsettings.json      # Configuração (BD, JWT, etc)
    └── … outros arquivos de suporte

------------------------------------------------------------------------

## 🔧 Tecnologias

-   .NET / ASP.NET Core\
-   Entity Framework Core\
-   Banco de dados SQL Server

------------------------------------------------------------------------

## 🚀 Como Executar Localmente

1.  Clone o repositório:

    ``` bash
    git clone https://github.com/DevPeress/EduConnect-API.git
    cd EduConnect-API
    ```

2.  Configure o **appsettings.json** e defina a conexão com o banco.

3.  Execute as migrações:

    ``` bash
    dotnet ef database update
    ```

4.  Execute a API:

    ``` bash
    dotnet run --project EduConnect‑API
    ```
