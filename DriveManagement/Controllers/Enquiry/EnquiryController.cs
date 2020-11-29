using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriveDomain.DomainDtos;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Mvc;


namespace DriveManagement.Controllers.Enquiry
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnquiryController : ControllerBase
    {
        private readonly IEnquiryDomainService _enquiryDomainService;

        // GET: api/<StudentController>
        public EnquiryController(IEnquiryDomainService stduentDomainService)
        {
            this._enquiryDomainService = stduentDomainService;
        }
        [HttpGet]
        public Task<IEnumerable<EnquiryDto>> Get()
        {
            return  _enquiryDomainService.Get();
        }

        [HttpGet("{id}")]
        public  Task<EnquiryDto> Get(long id)
        {
            return  _enquiryDomainService.GetById(id);
        }

        [HttpPost(nameof(Add))]
        public  Task<EnquiryDto> Add([FromBody]EnquiryDto  enquiry)
        {
            return  _enquiryDomainService.Add(enquiry);
        }

        // PUT api/<StudentController>/5
        [HttpPost(nameof(Update))]
        public  Task<EnquiryDto>  Update([FromBody] EnquiryDto enquiry)
        {
            return  _enquiryDomainService.Update(enquiry);
        }

        [HttpDelete]
        public  Task Delete(int id)
        {
            return  _enquiryDomainService.delete(id);
        }
    }
}
