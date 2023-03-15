using Microsoft.EntityFrameworkCore;
using MVC_CRUD_.Models.Domain;

namespace MVC_CRUD_.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Employee> Employeees { get; set; }


    }
}
