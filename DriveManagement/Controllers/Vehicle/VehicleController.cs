using DriveDomain.DomainServices;
using DriveEntities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DriveManagement.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleDomainService _vehicleDomainService;

        // GET: api/<StudentController>
        public VehicleController(IVehicleDomainService vehicleDomainService)
        {
            this._vehicleDomainService = vehicleDomainService;
        }

        [HttpGet]
        public Task<IEnumerable<VehicleDto>> Get()
        {
            return _vehicleDomainService.Get();
        }

        [HttpGet("{id}")]
        public Task<VehicleDto> Get(int id)
        {
            return _vehicleDomainService.Get(id);
        }

        [HttpPost(nameof(Add))]
        public Task<VehicleDto> Add([FromBody] VehicleDto vehicle)
        {
            return _vehicleDomainService.Add(vehicle);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<VehicleDto> Update([FromBody] VehicleDto vehicle)
        {
            return _vehicleDomainService.Update(vehicle);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _vehicleDomainService.delete(id);
        }
    }
}