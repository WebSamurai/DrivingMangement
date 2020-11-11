using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DriveManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudyController : ControllerBase
    {
       

        public StudyController()
        {
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Fetch()
        {
          return new []{ "Study 1", "study 2" };

        }
        [HttpGet(nameof(GetResult))]
        public ActionResult<IEnumerable<string>> GetResult()
        {
            return new[] { "r1 1", "r2" };

        }
    }
}
