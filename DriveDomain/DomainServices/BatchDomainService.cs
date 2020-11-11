using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public class BatchDomainService : DomainServiceBase<BatchDto, Batch, long>, IBatchDomainService
    {
        public BatchDomainService(IRepository<Batch, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
