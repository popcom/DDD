# SampleDDD

This repository contains a minimal Domain-Driven Design (DDD) style web API using ASP.NET Core 8.

## Projects

- **Domain**: Core business entities and repository interfaces.
- **Application**: Application services containing business logic.
- **Infrastructure**: Infrastructure implementations (in-memory repository).
- **WebApi**: ASP.NET Core minimal API exposing endpoints.

## Run

```bash
cd src/WebApi
dotnet run
```

You can then access Swagger UI at `https://localhost:5001/swagger` to test the API.

