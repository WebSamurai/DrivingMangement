using DriveDomain.DomainDtos;
using DriveEntities.Entities;

namespace DriveDomain.DomainServices
{
    public interface IEnquiryDomainService : IDomainService<EnquiryDto, Enquiry, long>
    {
    }
}