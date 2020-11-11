using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public class SchoolDomainService : DomainServiceBase<SchoolDto, School, long>, ISchoolDomainService
    {
        public SchoolDomainService(IRepository<School, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
