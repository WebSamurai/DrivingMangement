using System.Collections.Generic;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;


namespace DriveManagement.Controllers.StudentSchedule
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentScheduleController : ControllerBase
    {
        private readonly IStudentScheduleDomainService _studentScheduleDomainService;

        // GET: api/<StudentController>
        public StudentScheduleController(IStudentScheduleDomainService studentScheduleDomainService)
        {
            _studentScheduleDomainService = studentScheduleDomainService;
        }
        [HttpGet]
        public Task<IEnumerable<StudentScheduleDto>> GetScheduleForStudent(long studentId)
        {
            return _studentScheduleDomainService.GetScheduleForStudent(studentId);
        }

        [HttpGet("{id}")]
        public Task<StudentScheduleDto> Get(int id)
        {
            return _studentScheduleDomainService.GetById(id);
        }

        [HttpPost(nameof(Add))]
        public Task<StudentScheduleDto> Add([FromBody] StudentScheduleDto batch)
        {
            return _studentScheduleDomainService.Add(batch);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<StudentScheduleDto> Update([FromBody] StudentScheduleDto batch)
        {
            return _studentScheduleDomainService.Update(batch);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _studentScheduleDomainService.delete(id);
        }
    }
}
