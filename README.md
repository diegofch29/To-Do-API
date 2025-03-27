1. Clone the repository:

```sh
git clone https://github.com/diegofch29/To-Do-API
```

2. Configure the database connection in `appsettings.json`

3. Run the database migrations:

```sh
dotnet ef database update
```

4. Run the application:

```sh
dotnet run
```

The API will be available at `https://localhost:7128` or `http://localhost:5188`

## Development

- Build the project:

```sh
dotnet build
```

## API Endpoints

Documentation for the available API endpoints will go here.

## Technologies

- .NET 9
- Entity Framework Core
- PostgreSQL
- Aspire.Hosting
- ASP.NET Core Web API
