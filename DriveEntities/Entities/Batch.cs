﻿using DriveEntities.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblBatches")]
    public class Batch : EntityBase<long>
    {
        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public DateTime BatchTime { get; set; }

        public byte[] Photo { get; set; }
        public long SchoolId { get; set; }

        [ForeignKey(nameof(SchoolId))]
        public virtual School School { get; set; }

        public long BatchScheduleTemplateId { get; set; }

        [ForeignKey(nameof(BatchScheduleTemplateId))]
        public virtual BatchScheduleTemplate BatchScheduleTemplate { get; set; }
    }
}