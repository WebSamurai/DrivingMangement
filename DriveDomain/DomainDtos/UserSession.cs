using DriveEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain.DomainDtos
{
   public class UserSession
    {
        public long UserId { get; }
        public string UserName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public UserSession(User userDto)
        {
            UserId = userDto.Id;
            UserName = userDto.UserName;
            FirstName = userDto.FirstName;
            LastName = userDto.LastName;
        }
    }
}
