using AutoMapper;
using DrivePersistance;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain
{
  public static  class DomainModule
    {
        public static void RegisterSerives(IServiceCollection services)
        {
            PersitanceModule.RegisterSerives(services);
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new domainCumstomAutoMapper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient(typeof(IDomainService<,,>), typeof(DomainServiceBase<,,>));
        }
    }
}
