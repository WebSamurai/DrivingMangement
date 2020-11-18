using DriveEntities.Entities;
using System;

namespace DriveDomain.DomainDtos
{
    public class UserDto : EntityBase<long>
    {
        public virtual bool IsTwoFactorEnabled { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual bool IsPhoneNumberConfirmed { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool IsLockoutEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        public virtual string PasswordResetCode { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Password { get; set; }
        public virtual string FullName { get; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual bool IsEmailConfirmed { get; set; }
        public virtual string UserName { get; set; }
        public virtual string AuthenticationSource { get; set; }
        public virtual string EmailConfirmationCode { get; set; }
        public virtual bool IsActive { get; set; }
        public byte[] Photo { get; set; }
    }
}