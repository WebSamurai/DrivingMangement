using DriveEntityFramworkcore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveMigrator
{
   public static class Migrater
    {

      public static void Migrate(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            using (DriveDbContext driveDbContext = new DriveDbContext())
            {
                driveDbContext.configuration = configuration;
                driveDbContext.Database.Migrate();

            }
        }
    }
}
