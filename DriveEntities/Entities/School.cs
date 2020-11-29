using DriveEntities.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblSchools")]
    public class School : EntityBase<long>
    {
        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string Name { get; set; }

        [StringLength(DBColumnSize.MaxStringLength512)]
        public string Address { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public User User { get; set; }

        [Required]
        public long OwnerId { get; set; }

        [Required]
        public bool IsPrimary { get; set; }

        public byte[] LogoImage { get; set; }
        public string tagLine { get; set; }
    }
}