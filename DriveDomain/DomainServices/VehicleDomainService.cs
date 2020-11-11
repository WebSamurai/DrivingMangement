using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public class VehicleDomainService : DomainServiceBase<VehicleDto, Vehicle, long>,IVehicleDomainService
    {
        public VehicleDomainService(IRepository<Vehicle, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
