using DriveDomain.DomainDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveManagement.Controllers.Auth
{
    public class AuthencateResultModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }


        public AuthencateResultModel(UserDto user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
            Token = token;
        }
    }
}
