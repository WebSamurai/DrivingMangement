using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DriveDomain.DomainServices
{
    public interface IStudentScheduleDomainService : IDomainService<StudentScheduleDto, StudentSchedule, long>
    {
        Task<IEnumerable<StudentScheduleDto>> GetScheduleForStudent(long studentId);
    }
}
