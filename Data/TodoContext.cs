using Microsoft.EntityFrameworkCore;
using InteractiveTodoApp.Models;

namespace InteractiveTodoApp.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } // Ensure this property is defined
    }
}
