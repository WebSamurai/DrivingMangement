using DriveDomain.DomainDtos;
using DriveEntities.Entities;

namespace DriveDomain.DomainServices
{
    public interface ISchoolDomainService : IDomainService<SchoolDto, School, long>
    {
    }
}