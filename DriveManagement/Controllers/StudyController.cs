using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DriveManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudyController : ControllerBase
    {
       

        public StudyController()
        {
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
          return new []{ "Study 1", "study 2" };

        }
    }
}
