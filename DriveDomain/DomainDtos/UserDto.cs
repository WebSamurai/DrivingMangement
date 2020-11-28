using DriveEntities.Entities;
using System;

namespace DriveDomain.DomainDtos
{
    public class UserDto : EntityBase<long>
    {
        public  bool IsTwoFactorEnabled { get; set; }
        public  string SecurityStamp { get; set; }
        public  bool IsPhoneNumberConfirmed { get; set; }
        public  string PhoneNumber { get; set; }
        public  bool IsLockoutEnabled { get; set; }
        public  int AccessFailedCount { get; set; }
        public  DateTime? LockoutEndDateUtc { get; set; }
        public  string PasswordResetCode { get; set; }
        public  string EmailAddress { get; set; }
        public  string Password { get; set; }
        public  string FullName { get; }
        public  string LastName { get; set; }
        public  string FirstName { get; set; }
        public  bool IsEmailConfirmed { get; set; }
        public  string UserName { get; set; }
        public  string AuthenticationSource { get; set; }
        public  string EmailConfirmationCode { get; set; }
        public  bool IsActive { get; set; }
        public  string schoolName { get; set; }
        public byte[] Photo { get; set; }
    }
}