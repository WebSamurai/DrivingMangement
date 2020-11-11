using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public interface IStudentDomainService : IDomainService<StudentDto, Student, long>
    {
        
    }
}
