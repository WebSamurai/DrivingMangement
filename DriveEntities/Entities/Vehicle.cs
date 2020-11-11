using DriveEntities.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveEntities.Entities
{
    [Table("tblVehicles")]
    public class Vehicle : EntityBase<long>
    {
        [Required]
        [StringLength(DBColumnSize.MaxStringLength256)]
        public string ModelName { get; set; }

        [Required]
        [StringLength(DBColumnSize.MaxStringLength16)]
        public string Number { get; set; }

        public byte[] Photo { get; set; }
    }
}