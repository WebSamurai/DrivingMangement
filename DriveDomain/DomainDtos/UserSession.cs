using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain.DomainDtos
{
   public class UserSession
    {
        public long UserId { get; }
        public string UserName { get; }
        public string Name { get; }
        public UserSession(UserDto userDto)
        {
            UserId = userDto.Id;
            UserName = userDto.UserName;
            Name = userDto.Name;
        }
    }
}
