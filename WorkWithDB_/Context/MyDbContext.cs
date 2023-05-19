
using Microsoft.EntityFrameworkCore;
using WorkWithDB_.Models;

namespace WorkWithDB_.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<ServiceStation> ServiceStations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Motorist> Motorists { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server = localhost; Database = car_services_db; User = root; Password = password; Port = 3306;");
        }

    }

}
