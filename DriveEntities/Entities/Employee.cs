using DriveEntities.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblEmployees")]
    public class Employee : EntityBase<long>
    {
        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string FirstName { get; set; }

        [StringLength(DBColumnSize.MaxStringLength256)]
        public string MidleName { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string LastName { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxStringLength512)]
        public string Address { get; set; }

        [Required]
        public JobType JobType { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxStringLength12)]
        public string MobileNo { get; set; }

        [StringLength(DBColumnSize.MaxStringLength12)]
        public string AlternateNo { get; set; }

        public byte[] ProfilePicture { get; set; }
        public long SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; }
    }
}