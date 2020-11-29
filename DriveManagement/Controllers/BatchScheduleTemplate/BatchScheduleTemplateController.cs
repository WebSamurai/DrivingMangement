using System.Collections.Generic;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;


namespace DriveManagement.Controllers.BatchScheduleTemplate
{
    [ApiController]
    [Route("api/[controller]")]
    public class BatchScheduleTemplateController : ControllerBase
    {
        private readonly IBatchScheduleTemplateDomainService _batchScheduleTemplateDomainService;

        // GET: api/<StudentController>
        public BatchScheduleTemplateController(IBatchScheduleTemplateDomainService BbtchScheduleTemplateDomainService)
        {
            _batchScheduleTemplateDomainService = BbtchScheduleTemplateDomainService;
        }
        [HttpGet]
        public Task<IEnumerable<BatchScheduleTemplateDto>> Get()
        {
            return _batchScheduleTemplateDomainService.Get();
        }

        [HttpGet("{id}")]
        public Task<BatchScheduleTemplateDto> Get(int id)
        {
            return _batchScheduleTemplateDomainService.GetById(id);
        }

        [HttpPost(nameof(Add))]
        public Task<BatchScheduleTemplateDto> Add([FromBody] BatchScheduleTemplateDto batch)
        {
            return _batchScheduleTemplateDomainService.Add(batch);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<BatchScheduleTemplateDto> Update([FromBody] BatchScheduleTemplateDto batch)
        {
            return _batchScheduleTemplateDomainService.Update(batch);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _batchScheduleTemplateDomainService.delete(id);
        }
    }
}
