using DEMO_2.Models;
using Microsoft.EntityFrameworkCore;
namespace DEMO_2.Data {
    public class EmployeeContext : DbContext {
        public EmployeeContext (DbContextOptions options) : base (options) {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}