using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using DriveManagement.Middleware;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DriveManagement.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserDomainService _userDomainService;

        // GET: api/<StudentController>
        public UserController(IUserDomainService userDomainService)
        {
            this._userDomainService = userDomainService;
        }

        [HttpGet]
        [Authorize]
        public Task<IEnumerable<UserDto>> Get()
        {
            return _userDomainService.Get();
        }

        [HttpGet("{id}")]
        public Task<UserDto> Get(int id)
        {
            return _userDomainService.GetById(id);
        }

        [HttpPost(nameof(Add))]
        public Task<UserDto> Add([FromBody] UserDto employee)
        {
            return _userDomainService.Add(employee);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<UserDto> Update([FromBody] UserDto employee)
        {
            return _userDomainService.Update(employee);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _userDomainService.delete(id);
        }
    }
}