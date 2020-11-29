using AutoMapper;
using DriveDomain.DomainServices;
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
                mc.AddProfile(new DomainCumstomAutoMapper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            Register(services);
        }
      private static void   Register(IServiceCollection services)
        {
            services.AddTransient(typeof(IDomainService<,,>), typeof(DomainServiceBase<,,>));
            services.AddTransient(typeof(IUserDomainService), typeof(UserDomainService));
            services.AddTransient(typeof(IEmployeeDomainService), typeof(EmployeeDomainService));
            services.AddTransient(typeof(IBatchDomainService), typeof(BatchDomainService));
            services.AddTransient(typeof(ISchoolDomainService), typeof(SchoolDomainService));
            services.AddTransient(typeof(IVehicleDomainService), typeof(VehicleDomainService));
            services.AddTransient(typeof(IStudentDomainService), typeof(StudentDomainService));
            services.AddTransient(typeof(IEnquiryDomainService), typeof(EnquiryDomainService));
            services.AddTransient(typeof(IBatchScheduleTemplateDomainService), typeof(BatchScheduleTemplateDomainService));
            services.AddTransient(typeof(IStudentScheduleDomainService), typeof(StudentScheduleDomainService));
        }
        
    }
}
