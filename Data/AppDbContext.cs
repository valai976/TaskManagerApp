using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;

namespace TaskManagerApp.Data
{
    // This class represents the database context for the application, allowing us to interact with the database using Entity Framework Core.
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }
        // This property represents the Tasks table in the database, allowing us to perform CRUD operations on TaskItem entities.
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
