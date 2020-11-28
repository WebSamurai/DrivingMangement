using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DriveManagement.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectController : ControllerBase
    {

        [HttpGet(nameof(GetStudy))]
        public IEnumerable<SelectItem<long>> GetStudy([FromServices] ISchoolDomainService schoolDomainService)
        {

            return schoolDomainService.Query().AsNoTracking().Select(x => new SelectItem<long> { Value = x.Id, Label = x.Name });
        }
        [HttpGet(nameof(GetBatch))]
        public IEnumerable<SelectItem<long>> GetBatch([FromServices] IBatchDomainService batchDomainService)
        {

            return batchDomainService.Query().AsNoTracking().Select(x => new SelectItem<long> { Value = x.Id, Label = x.Name });
        }
    }
}
