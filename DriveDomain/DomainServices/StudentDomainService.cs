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
    public class StudentDomainService : DomainServiceBase<StudentDto, Student, long>, IStudentDomainService
    {
        public StudentDomainService(IRepository<Student, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }

        public async Task<IEnumerable<StudentListDto>> GetStudentList()
        {
            return await repository.GetQuery().Include(x => x.Batch).Include(x => x.School).AsNoTracking()
                .Select(x => autoMapper.Map<StudentListDto>(x)).ToListAsync();
        }
    }
}
