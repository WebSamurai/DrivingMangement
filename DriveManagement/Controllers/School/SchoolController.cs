using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DriveManagement.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolDomainService _schoolDomainService;

        // GET: api/<StudentController>
        public SchoolController(ISchoolDomainService schoolDomainService)
        {
            this._schoolDomainService = schoolDomainService;
        }

        [HttpGet]
        public Task<IEnumerable<SchoolDto>> Get()
        {
            return _schoolDomainService.Get();
        }

        [HttpGet("{id}")]
        public Task<SchoolDto> Get(int id)
        {
            return _schoolDomainService.GetById(id);
        }

        [HttpPost(nameof(Add))]
        public Task<SchoolDto> Add([FromBody] SchoolDto school)
        {
            return _schoolDomainService.Add(school);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<SchoolDto> Update([FromBody] SchoolDto school)
        {
            return _schoolDomainService.Update(school);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _schoolDomainService.delete(id);
        }
    }
}