using Microsoft.EntityFrameworkCore;
using MyCompany_Blazor.Shared.Entitites;

namespace MyCompany_Blazor.Server.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Job> Jobs { get; set; }
    }
}