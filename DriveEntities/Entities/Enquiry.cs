using DriveEntities.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblEnquiries")]
    public class Enquiry : EntityBase<long>
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
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string Address { get; set; }

        public DateTime EnquiryStartDate { get; set; }
        public DateTime? FollowupDate { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string EmailAddress { get; set; }

        [Required]
        public string MobileNo { get; set; }

        public bool isWatsApp { get; set; }

        [StringLength(DBColumnSize.MaxStringLength12)]
        public string AlternateNo { get; set; }

        public byte[] ProfilePicture { get; set; }
        public bool CloseEnquiry { get; set; }
        public long SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; }
    }
}