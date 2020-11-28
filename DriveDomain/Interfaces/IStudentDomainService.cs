using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DriveDomain.DomainServices
{
    public interface IStudentDomainService : IDomainService<StudentDto, Student, long>
    {
        Task<IEnumerable<StudentListDto>> GetStudentList();
    }
}
