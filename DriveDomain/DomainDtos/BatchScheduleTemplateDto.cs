using DriveEntities.Configuration;
using DriveEntities.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace DriveDomain.DomainDtos
{
    public class BatchScheduleTemplateDto : EntityBase<long>
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
    }
}