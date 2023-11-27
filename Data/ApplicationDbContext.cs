using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;
using Employee_Management_System.Model;

namespace Employee_Management_System.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeContactInfo> ContactInfo { get; set; }
    }
}
