using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }

        public DbSet<EmployeeManagement.Models.Departments>? Departments { get; set; }
    }
}
