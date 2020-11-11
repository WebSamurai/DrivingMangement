using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public class StudentDomainService : DomainServiceBase<StudentDto, Student, long>, IStudentDomainService
    {
        public StudentDomainService(IRepository<Student, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
