using DriveEntities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DriveEntityFramworkcore
{
    public class DriveDbContext :DbContext
    {
        public DriveDbContext(IConfiguration configuration) :base()
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get;}
        
        public DbSet<School> Schools { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseNpgsql(Configuration["Data:DefaultConnection:ConnectionString"]);
    }
}
