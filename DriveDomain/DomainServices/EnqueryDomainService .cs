using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DriveDomain.DomainServices
{
    public class EnqueryDomainService : DomainServiceBase<EnquiryDto, Enquiry, long>, IEnquiryDomainService
    {
        private readonly IRepository<Enquiry, long> repository;

        public EnqueryDomainService(IRepository<Enquiry, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
            this.repository = repository;
        }
      
    }
}
