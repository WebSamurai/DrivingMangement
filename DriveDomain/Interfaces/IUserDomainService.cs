using DriveDomain.DomainDtos;
using DriveEntities.Entities;

namespace DriveDomain.DomainServices
{
    public interface IUserDomainService : IDomainService<UserDto, User, long>
    {
    }
}