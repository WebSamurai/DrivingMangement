using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DriveEntities.Entities
{
    [Table("tblUsers")]
    public class User : EntityBase<long>
    {
        public virtual bool IsTwoFactorEnabled { get; set; }
        [StringLength(128)]
        public virtual string SecurityStamp { get; set; } = Guid.NewGuid().ToString();
        public virtual bool IsPhoneNumberConfirmed { get; set; }
        [StringLength(32)]
        public virtual string PhoneNumber { get; set; }
        public virtual bool IsLockoutEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        [StringLength(328)]
        public virtual string PasswordResetCode { get; set; }
        [Required]
        [StringLength(256)]
        public virtual string EmailAddress { get; set; }
        [Required]
        [StringLength(128)]
        public virtual string Password { get; set; }
        [NotMapped]
        public virtual string FullName { get; }
        [Required]
        [StringLength(64)]
        public virtual string Surname { get; set; }
        [Required]
        [StringLength(64)]
        public virtual string Name { get; set; }
        public virtual bool IsEmailConfirmed { get; set; }
        //
        // Summary:
        //     Tenant Id of this user.
        //
        // Summary:
        //     User name. User name must be unique for it's tenant.
        [Required]
        [StringLength(256)]
        public virtual string UserName { get; set; }
        [StringLength(64)]
        public virtual string AuthenticationSource { get; set; }
        [StringLength(328)]
        public virtual string EmailConfirmationCode { get; set; }
        public virtual bool IsActive { get; set; } = true;
    }
}
