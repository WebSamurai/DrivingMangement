using DriveEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DriveEntityFramworkcore
{
    public class DriveDbContext :DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ManageDriveDb;User ID=tclocal_migratoruser;Password=TCEP;Pooling=true;");
    }
}
