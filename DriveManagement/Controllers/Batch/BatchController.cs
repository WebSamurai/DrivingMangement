using System.Collections.Generic;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;


namespace DriveManagement.Controllers.Batch
{
    [ApiController]
    [Route("api/[controller]")]
    public class BatchController : ControllerBase
    {
        private readonly IBatchDomainService _batchDomainService;

        // GET: api/<StudentController>
        public BatchController(IBatchDomainService batchDomainService)
        {
            this._batchDomainService = batchDomainService;
        }
        [HttpGet]
        public Task<IEnumerable<BatchDto>> Get()
        {
            return _batchDomainService.Get();
        }

        [HttpGet("{id}")]
        public Task<BatchDto> Get(int id)
        {
            return _batchDomainService.GetById(id);
        }

        [HttpPost(nameof(Add))]
        public Task<BatchDto> Add([FromBody] BatchDto batch)
        {
            return _batchDomainService.Add(batch);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<BatchDto> Update([FromBody] BatchDto batch)
        {
            return _batchDomainService.Update(batch);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _batchDomainService.delete(id);
        }
    }
}
