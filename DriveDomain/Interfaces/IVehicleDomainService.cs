using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public interface IVehicleDomainService : IDomainService<VehicleDto, Vehicle, long>
    {
        
    }
}
