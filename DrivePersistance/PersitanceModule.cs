using DriveEntityFramworkcore;
using DrivePersistance.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrivePersistance
{
   public static class PersitanceModule
    {
      public static  void RegisterSerives(IServiceCollection services)
        {
            services.AddDbContext<DriveDbContext>();
            services.AddTransient(typeof(IRepository<,>), typeof(Repository<,>));
        }
    }
}
