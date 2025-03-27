using Microsoft.EntityFrameworkCore;
using to_do_api.Configurations;
using to_do_api.Model;

namespace to_do_api.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }

        public DbSet<TodoTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoTaskConfiguration());
        }
    }
}