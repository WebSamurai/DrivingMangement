using AutoMapper;
using DriveEntities.Entities;
using DrivePersistance.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveDomain
{

    public class DomainServiceBase<TDto, T, tkey> : IDomainService<TDto, T, tkey> where T : EntityBase where TDto : EntityBase
    {
        protected readonly IRepository<T, tkey> repository;
        private readonly IMapper autoMapper;
        public Action Validator= ()=> { };

        public DomainServiceBase(IRepository<T, tkey> repository,IMapper autoMapper)
        {
            this.repository = repository;
            this.autoMapper = autoMapper;
        }


        public virtual async Task<TDto> Add(TDto t)
        {
            Validator();
            var data = autoMapper.Map<T>(t);
           await repository.Add(data);
            return t;
        }

   

        public virtual async Task delete(TDto t)
        {
            Validator();
            var data = autoMapper.Map<T>(t);
           await repository.Delete(data);
        }

        public virtual async Task<IEnumerable<TDto>> Get()
        {
            return Enumerable.Empty<TDto>();
        }

        public async Task<TDto> Get(tkey id)
        {
            Validator();
            return autoMapper.Map<TDto>(await repository.Get(id));
        }

        public async  Task<TDto> Update(TDto t)
        {
            Validator();
            var data = autoMapper.Map<T>(t);
            await repository.Add(data);
            return t;
        }
    }
}