using Microsoft.EntityFrameworkCore;

// Schema is owned by Flyway; EF is used for querying only (no EF migrations).
public class TodoDb(DbContextOptions<TodoDb> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>(e =>
        {
            e.ToTable("Todo");
            e.Property(t => t.CreatedAt).ValueGeneratedOnAdd();
        });
    }
}
