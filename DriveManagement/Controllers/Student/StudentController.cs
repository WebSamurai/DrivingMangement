using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;


namespace DriveManagement.Controllers.Student
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentDomainService _stduentDomainService;

        // GET: api/<StudentController>
        public StudentController(IStudentDomainService stduentDomainService)
        {
            this._stduentDomainService = stduentDomainService;
        }
        [HttpGet]
        public Task<IEnumerable<StudentDto>> Get()
        {
            return  _stduentDomainService.Get();
        }

        [HttpGet("{id}")]
        public  Task<StudentDto> Get(int id)
        {
            return  _stduentDomainService.Get(id);
        }

        [HttpPost(nameof(Add))]
        public  Task<StudentDto> Add([FromBody]StudentDto  student)
        {
            return  _stduentDomainService.Add(student);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public  Task<StudentDto>  Update([FromBody] StudentDto  student)
        {
            return  _stduentDomainService.Update(student);
        }

        [HttpDelete]
        public  Task Delete(int id)
        {
            return  _stduentDomainService.delete(id);
        }
    }
}
