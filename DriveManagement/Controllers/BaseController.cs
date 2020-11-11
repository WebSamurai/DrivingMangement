using DriveDomain;
using DriveDomain.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TDto> : ControllerBase
    {
        protected readonly ICommonDomainService _domainService;

        // GET: api/<StudentController>
        public BaseController(ICommonDomainService commonDomainService)
        {
            this._domainService = commonDomainService;
        }

        [HttpGet]
        public async Task<IEnumerable<TDto>> Get()
        {
            return await _domainService.Get<TDto>();
        }

        [HttpGet(nameof(GetById))]
        public async Task<TDto> GetById(long id)
        {
            return await _domainService.Get<long, TDto>(id);
        }

        [HttpPost(nameof(Add))]
        public async Task<TDto> Add([FromBody] TDto student)
        {
            return await _domainService.Add(student);
        }

        [HttpPost(nameof(Update))]
        public async Task<TDto> Update([FromBody] TDto student)
        {
            return await _domainService.Update(student);
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _domainService.delete(id);
        }
    }
}
