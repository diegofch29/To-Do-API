1. Clone the repository:

```sh
git clone https://github.com/diegofch29/To-Do-API
```


2. Configure the database connection in `appsettings.json`

```sh
   cd To-Do-API
```

3. Configure the database connection in `appsettings.json`

```sh
   {
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
      }
    },
    "ConnectionStrings": {
      "DefaultConnection": "<db_connection_string>"
    },
    "AllowedHosts": "*"
  }
```

4. Run the database migrations:

```sh
dotnet ef database update
```

4. Run the application:

```sh
dotnet run
```

The API will be available at `http://localhost:5188`

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
- ASP.NET Core Web API
