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
        private readonly ISchoolDomainService _schoolDomainService;

        // GET: api/<StudentController>
        public UserController(IUserDomainService userDomainService , ISchoolDomainService schoolDomainService)
        {
            this._userDomainService = userDomainService;
            this._schoolDomainService = schoolDomainService;
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
        public async Task<UserDto> Add([FromBody] UserDto user)
        {
            var result=  await _userDomainService.Add(user);
            var school = new SchoolDto()
            {
                Name = user.schoolName,
                OwnerId = result.Id,
                IsPrimary=true
            };
            await _schoolDomainService.Add(school);
            return result;
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public Task<UserDto> Update(UserDto user)
        {
            return _userDomainService.Update(user);
        }

        [HttpDelete]
        public Task Delete(int id)
        {
            return _userDomainService.delete(id);
        }
    }
}