using DriveEntities.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblBatchScheduleTemplate")]
    public class BatchScheduleTemplate : EntityBase<long>
    {
        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int NumberOfPracticalSession { get; set; }
        [Required]
        public int NumberOfTheorySession { get; set; }
        //default therory time and practical time is batch while generating schedule latter can change
        public DateTime TheoryTime { get; set; }

        //default therory time and practical time is batch
        public DateTime? PracticalTime { get; set; }
        public long SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; }



    }
}