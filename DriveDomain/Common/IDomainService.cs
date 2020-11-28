using DriveEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DriveDomain
{
    public interface IDomainService<TDto, T, Tkey> where T : EntityBase where TDto : EntityBase
    {
        Task<TDto> Add(TDto t);

        Task<TDto> Update(TDto t);

        Task delete(Tkey tKey);

        Task<IEnumerable<TDto>> Get();

        Task<TDto> GetById(Tkey id);
        public  Task<IEnumerable<T>> Get(Expression<Func<T, bool>> func);
        public Task<TDto> Find(Expression<Func<T, bool>> func);
        public IQueryable<T> Query();
    }
}