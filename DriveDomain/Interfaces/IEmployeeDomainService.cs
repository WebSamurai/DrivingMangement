using DriveDomain.DomainDtos;
using DriveEntities.Entities;

namespace DriveDomain.DomainServices
{
    public interface IEmployeeDomainService : IDomainService<EmployeeDto, Employee, long>
    {
    }
}