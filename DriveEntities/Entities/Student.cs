using DriveEntities.Configuration;
using ManageDrive.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblStudents")]
    public class Student : EntityBase<long>
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
        public DateTime CourseStartDate { get; set; }

        public DateTime? CourseEndDate { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxStringLength12)]
        public string MobileNo { get; set; }

        public bool isWatsApp { get; set; }

        [StringLength(DBColumnSize.MaxStringLength12)]
        public string AlternateNo { get; set; }

        public byte[] ProfilePicture { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public long BatchId { get; set; }

        [ForeignKey(nameof(BatchId))]
        public virtual Batch Batch { get; set; }

        public long SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; }
    }
}