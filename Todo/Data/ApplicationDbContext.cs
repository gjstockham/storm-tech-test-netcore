namespace Todo.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Todo.Data.Entities;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TodoList>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            builder.Entity<TodoItem>(entity =>
            {
                entity.HasOne(d => d.TodoList)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.TodoListId);
            });
        }
    }
}
