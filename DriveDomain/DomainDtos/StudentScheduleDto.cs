using DriveEntities.Entities;
using System;

namespace DriveDomain.DomainDtos
{
    public class StudentScheduleDto : EntityBase<long>
    {
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleTime { get; set; }
        public bool IsAttended { get; set; }
        public ScheduleType Scheduletype { get; set; }
        public long BatchScheduleTemplateId { get; set; }

        public long StudentId { get; set; }
        public bool IsInstructorSignOff { get; set; }
        public long InstructorId { get; set; }
    }
}