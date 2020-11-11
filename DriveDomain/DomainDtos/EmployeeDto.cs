using DriveEntities.Entities;

namespace DriveDomain.DomainDtos
{
    public class EmployeeDto : EntityBase<long>
    {
        public string FirstName { get; set; }

        public string MidleName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public JobType JobType { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNo { get; set; }

        public string AlternateNo { get; set; }

        public byte[] ProfilePicture { get; set; }
        public long SchoolId { get; set; }
        public virtual SchoolDto School { get; set; }
    }
}