using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DriveDomain.DomainServices
{
    public class SchoolDomainService : DomainServiceBase<SchoolDto, School, long>, ISchoolDomainService
    {
        private readonly IRepository<School, long> repository;

        public SchoolDomainService(IRepository<School, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
            this.repository = repository;
        }

        public  async Task<bool> IsSchoolNameExist(string name)
        {
            var result = await repository.GetQuery().AsNoTracking().AnyAsync(x => x.Name == name);
            return result;
        }
    }
}
