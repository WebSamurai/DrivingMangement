using DriveEntities.Entities;
using ManageDrive.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain.DomainDtos
{
   public class StudentListDto : EntityBase<long>
    {
        public string FirstName { get; set; }

        public string MidleName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime CourseStartDate { get; set; }

        public DateTime? CourseEndDate { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNo { get; set; }

        public bool isWatsApp { get; set; }

        public string AlternateNo { get; set; }

        public byte[] ProfilePicture { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public long BatchId { get; set; }

        public string BatchName { get; set; }

        public DateTime BatchStartDate { get; set; }

        public DateTime? BatchEndDate { get; set; }
        public DateTime BatchBatchTime { get; set; }


        public long SchoolId { get; set; }

        public string SchoolName { get; set; }
    }
}
