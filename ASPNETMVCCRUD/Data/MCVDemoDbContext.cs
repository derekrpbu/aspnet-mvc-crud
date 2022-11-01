using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Data
{
    public class MCVDemoDbContext : DbContext   // Inherit from db context
    {
        // Constructor
        public MCVDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        // Properties, used to access tables
        public DbSet<Employee> Employees { get; set; }  // Table created will also be name Employees


    }
}
