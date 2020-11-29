using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblStudentSchedule")]
    public class StudentSchedule : EntityBase<long>
    {
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleTime { get; set; }
        public bool IsAttended { get; set; }
        public ScheduleType Scheduletype { get; set; }
        public long BatchScheduleTemplateId { get; set; }

        [ForeignKey(nameof(BatchScheduleTemplateId))]
        public virtual BatchScheduleTemplate BatchScheduleTemplate { get; set; }
        public long StudentId { get; set; }

        public bool IsInstructorSignOff { get; set; }
        [ForeignKey(nameof(StudentId))]
        public virtual Student Student { get; set; }
        public long InstructorId { get; set; }


    }
}