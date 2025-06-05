# SampleDDD

A minimal Domain-Driven Design (DDD) style API using ASP.NET Core 8.

## Solution structure

The solution is split into four projects:

- **Domain** – contains the `TodoItem` entity and `ITodoRepository` interface.
- **Application** – application services such as `TodoService` which orchestrate the domain.
- **Infrastructure** – infrastructure implementations. An in-memory repository (`InMemoryTodoRepository`) is provided for demos.
- **WebApi** – ASP.NET Core minimal API exposing the HTTP endpoints.

```
SampleDDD.sln
 ├─ Domain
 ├─ Application
 ├─ Infrastructure
 └─ WebApi
```

## Prerequisites

- .NET SDK 8.0

Verify the SDK is installed:

```bash
dotnet --version
```

## Build and run

To build the entire solution from the command line:

```bash
dotnet build SampleDDD.sln
```

To run the API:

```bash
dotnet run --project src/WebApi/SampleDDD.WebApi.csproj
```

You can also open `SampleDDD.sln` in Visual Studio and run the WebApi project from there.

Swagger is enabled in development. Once running, navigate to `http://localhost:5176/swagger` (or the URL printed by `dotnet run`) to explore the API interactively.

## API endpoints

| Method | Endpoint           | Description                   |
|-------|-------------------|-------------------------------|
| `POST` | `/todos?title=todo` | Add a new todo item. Returns `200 OK`.
| `GET`  | `/todos`           | Returns all todo items as JSON array.
| `GET`  | `/todos/{id}`      | Returns the todo with the specified `id` or `404` if not found.

Example request to create and retrieve items using `curl`:

```bash
# Add a todo
curl -X POST "http://localhost:5176/todos?title=Buy%20milk"

# List todos
curl http://localhost:5176/todos

# Get one by id
curl http://localhost:5176/todos/<id>
```

