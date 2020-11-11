using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DriveManagement.Controllers.Student
{
    public class StudentController : ControllerBase
    {
        private readonly IStudentDomainService _stduentDomainService;

        // GET: api/<StudentController>
        public StudentController(IStudentDomainService stduentDomainService)
        {
            this._stduentDomainService = stduentDomainService;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public async Task<StudentDto> Get(int id)
        {
            
        }

        [HttpPost]
        public async Task<StudentDto> Add([FromBody]StudentDto  student)
        {
            return await _stduentDomainService.Add(student);
        }

        // PUT api/<StudentController>/5
        [HttpPost]
        public async Task<StudentDto>  Update([FromBody] StudentDto  student)
        {
            return await _stduentDomainService.Update(student);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            return await _stduentDomainService.delete(student);
        }
    }
}
