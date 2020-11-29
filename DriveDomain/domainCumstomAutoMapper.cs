using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain
{
    public class DomainCumstomAutoMapper:Profile
    {
        public DomainCumstomAutoMapper()
        {
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<Student, StudentListDto>()
                .ForMember(x => x.BatchName, opt => opt.MapFrom(x => x.Batch.Name))
                .ForMember(x => x.BatchBatchTime, opt => opt.MapFrom(x => x.Batch.BatchTime))
                .ForMember(x => x.BatchStartDate, opt => opt.MapFrom(x => x.Batch.StartDate))
                .ForMember(x => x.BatchEndDate, opt => opt.MapFrom(x => x.Batch.EndDate));
            CreateMap<Enquiry, EnquiryDto>().ReverseMap().ForMember(x => x.School, opt => opt.Ignore()); ;
            CreateMap<Batch, BatchDto>().ReverseMap().ForMember(x => x.School, opt => opt.Ignore()); ;
            CreateMap<Vehicle, VehicleDto>().ReverseMap() ;
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap().ForMember(x => x.School, opt => opt.Ignore()); 
            CreateMap<SchoolDto, School>().ForMember(x=>x.User,opt=> opt.Ignore());
            CreateMap<School, SchoolDto>();
            CreateMap<BatchScheduleTemplate, BatchScheduleTemplateDto>().ReverseMap();
            CreateMap<StudentSchedule, StudentScheduleDto>().ReverseMap();
            CreateMap<List<StudentSchedule>, List<StudentScheduleDto>>().ReverseMap();
        }
    }
}
