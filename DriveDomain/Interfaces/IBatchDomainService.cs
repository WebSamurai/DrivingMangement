using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public interface IBatchDomainService : IDomainService<BatchDto, Batch, long>
    {
      
    }
}
