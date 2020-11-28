using DriveEntities.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveDomain.DomainDtos
{
    public class SchoolDto : EntityBase<long>
    {
        public string Name { get; set; }

        public string Address { get; set; }
        [NotMapped]
        public UserDto User { get; set; }

        public long OwnerId { get; set; }

        public bool IsPrimary { get; set; }
        public byte[] LogoImage { get; set; }

        public string tagLine { get; set; }
    }
}