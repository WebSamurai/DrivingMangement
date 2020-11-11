using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain.DomainServices
{
    public interface IUserDomainService : IDomainService<UserDto, User, long>
    {
       
    }
}
