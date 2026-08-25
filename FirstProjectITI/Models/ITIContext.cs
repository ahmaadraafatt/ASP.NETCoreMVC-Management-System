using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FirstProjectITI.Models
{
    public class ITIContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FirstProjectITI;Trusted_Connection=True;");
        }
        public ITIContext() : base()
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> students { get; set; }
    }

}
