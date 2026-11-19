# FlywayDemo

.NET 10 minimal API + SQL Server 2022 + Flyway, run with Podman/Docker compose.
Flyway owns the schema; EF Core is used only for queries.

## Run
    cp .env.example .env
    podman compose up --build
    curl localhost:8080/todos

## Flyway cheat sheet (service `flyway`, config in flyway/flyway.toml)
    podman compose run --rm flyway -workingDirectory=project info
    podman compose run --rm flyway -workingDirectory=project validate
    podman compose run --rm flyway -workingDirectory=project migrate
    podman compose run --rm flyway -workingDirectory=project repair

## Exercises
1. Add `V4__...sql`, run `migrate`: only V4 applies.
2. Edit V1 after it's applied, run `validate`: checksum mismatch. Revert it (or `repair`).
3. Change `R__todo_summary_view.sql`, run `migrate`: only the repeatable reruns.
4. Query history: `SELECT * FROM FlywayDemo.dbo.flyway_schema_history`.
