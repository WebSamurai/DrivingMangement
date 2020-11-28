using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using System.Threading.Tasks;

namespace DriveDomain.DomainServices
{
    public interface ISchoolDomainService : IDomainService<SchoolDto, School, long>
    {
        Task<bool> IsSchoolNameExist(string name);
    }
}