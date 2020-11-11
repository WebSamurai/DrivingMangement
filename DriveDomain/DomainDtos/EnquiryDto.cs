using DriveEntities.Entities;
using System;

namespace DriveDomain.DomainDtos
{
    public class EnquiryDto : EntityBase<long>
    {
        public string FirstName { get; set; }

        public string MidleName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime EnquiryStartDate { get; set; }
        public DateTime? FollowupDate { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }

        public bool isWatsApp { get; set; }

        public string AlternateNo { get; set; }

        public byte[] ProfilePicture { get; set; }
        public bool CloseEnquiry { get; set; }
        public long SchoolId { get; set; }
        public virtual SchoolDto School { get; set; }
    }
}