using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain
{
    public class domainCumstomAutoMapper:Profile
    {
        public domainCumstomAutoMapper()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Enquiry, EnquiryDto>().ReverseMap();
            CreateMap<Batch, BatchDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
