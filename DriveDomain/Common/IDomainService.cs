using DriveEntities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DriveDomain
{
    public interface IDomainService<TDto, T, tkey> where T : EntityBase where TDto : EntityBase
    {
        Task<TDto> Add(TDto t);

        Task<TDto> Update(TDto t);

        Task delete(TDto t);

        Task<IEnumerable<TDto>> Get();

        Task<TDto> Get(tkey id);
    }
}