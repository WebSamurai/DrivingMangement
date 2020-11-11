using System.Collections.Generic;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;


namespace DriveManagement.Controllers.Employee
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDomainService _employeeDomainService;

        // GET: api/<StudentController>
        public EmployeeController(IEmployeeDomainService employeeDomainService)
        {
            this._employeeDomainService = employeeDomainService;
        }
        [HttpGet]
        public Task<IEnumerable<EmployeeDto>> Get()
        {
            return _employeeDomainService.Get();
        }

        [HttpGet("{id}")]
        public Task<EmployeeDto> Get(int id)
        {
            return _employeeDomainService.Get(id);
        }

        [HttpPost(nameof(Add))]
        public Task<EmployeeDto> Add([FromBody] EmployeeDto employee)
        {
            return _employeeDomainService.Add(employee);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<EmployeeDto> Update([FromBody] EmployeeDto employee)
        {
            return _employeeDomainService.Update(employee);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _employeeDomainService.delete(id);
        }
    }
}
