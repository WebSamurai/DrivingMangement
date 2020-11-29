using AutoMapper;
using DriveDomain.DomainDtos;
using DriveEntities.Entities;
using DrivePersistance.Common;

namespace DriveDomain.DomainServices
{
    public class BatchScheduleTemplateDomainService : DomainServiceBase<BatchScheduleTemplateDto, BatchScheduleTemplate, long>, IBatchScheduleTemplateDomainService
    {
        public BatchScheduleTemplateDomainService(IRepository<BatchScheduleTemplate, long> repository, IMapper autoMapper) : base(repository, autoMapper)
        {
        }
    }
}
