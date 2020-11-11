using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveDomain.DomainServices
{
    public class UserDomainService : DomainServiceBase<UserDto, User, long>, IUserDomainService
    {
        public UserDomainService(IRepository<User, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
