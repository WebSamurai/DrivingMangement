using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveDomain.DomainServices
{
    public class StudentScheduleDomainService : DomainServiceBase<StudentScheduleDto, StudentSchedule, long>, IStudentScheduleDomainService
    {
        public StudentScheduleDomainService(IRepository<StudentSchedule, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
        public  async Task<IEnumerable<StudentScheduleDto>> GetScheduleForStudent(long studentId)
        {
            return await repository.GetQuery().Where(s=>s.StudentId==studentId).AsNoTracking().OrderBy(x => x.Id).Select(x => autoMapper.Map<StudentScheduleDto>(x)).ToListAsync();
        }
    }
}
