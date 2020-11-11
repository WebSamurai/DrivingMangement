using DriveEntities.Entities;

namespace DriveDomain.DomainDtos
{
    public class SchoolDto : EntityBase<long>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public UserDto User { get; set; }

        public long OwnerId { get; set; }

        public bool IsPrimary { get; set; }

        public string tagLine { get; set; }
    }
}