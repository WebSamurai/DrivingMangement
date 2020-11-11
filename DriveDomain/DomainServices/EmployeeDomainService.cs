using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public class EmployeeDomainService : DomainServiceBase<EmployeeDto, Employee, long>, IEmployeeDomainService
    {
        public EmployeeDomainService(IRepository<Employee, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
