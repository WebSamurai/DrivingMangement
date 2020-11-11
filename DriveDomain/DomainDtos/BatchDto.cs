using DriveEntities.Entities;
using System;
using System.Collections.Generic;

namespace DriveDomain.DomainDtos
{
    public class BatchDto : EntityBase<long>
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public DateTime BatchTime { get; set; }

        public List<StudentDto> Students { get; set; }
        public byte[] Photo { get; set; }
        public long SchoolId { get; set; }
        public virtual SchoolDto School { get; set; }
    }
}