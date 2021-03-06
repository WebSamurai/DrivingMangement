﻿using AutoMapper;
using DriveEntities.Entities;
using DrivePersistance.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DriveDomain
{
    public class DomainServiceBase<TDto, T, Tkey> : IDomainService<TDto, T, Tkey> where T : EntityBase<Tkey> where TDto : EntityBase<Tkey>
    {
        protected readonly IRepository<T, Tkey> repository;
        protected readonly IMapper autoMapper;
        public Action Validator = () => { };

        public DomainServiceBase(IRepository<T, Tkey> repository, IMapper autoMapper)
        {
            this.repository = repository;
            this.autoMapper = autoMapper;
        }

        public virtual async Task<TDto> Add(TDto t)
        {
            Validator();
            var data = autoMapper.Map<T>(t);
            var result = await repository.Add(data);
            return autoMapper.Map<TDto>(result); ;
        }

        public async Task<List<TDto>> Add(List<TDto> t)
        {
            Validator();
            var data = autoMapper.Map<List<T>>(t);
            var result = await repository.Add(data);
            return autoMapper.Map<List<TDto>>(result); ;
        }

        public virtual async Task delete(Tkey t)
        {
            Validator();
            var data = await repository.Get(t);
            await repository.Delete(data);
        }

        public async Task<TDto> Find(Expression<Func<T, bool>> func)
        {
            var result = (await repository.Get(func)).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            return autoMapper.Map<TDto>(result);
        }

        public virtual async Task<IEnumerable<TDto>> Get()
        {
            return await repository.GetQuery().AsNoTracking().OrderBy(x => x.Id).Select(x => autoMapper.Map<TDto>(x)).ToListAsync();
        }

        public Task<IEnumerable<T>> Get(Expression<Func<T, bool>> func)
        {
            return repository.Get(func);
        }

        public async Task<TDto> GetById(Tkey id)
        {
            Validator();
            return autoMapper.Map<TDto>(await repository.Get(id));
        }

        public IQueryable<T> Query()
        {
            return repository.GetQuery();
        }

        public async Task<TDto> Update(TDto t)
        {
            Validator();
            var data = autoMapper.Map<T>(t);
            await repository.Update(data);
            return t;
        }
    }
}