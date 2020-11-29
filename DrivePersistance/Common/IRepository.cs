using DriveEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DrivePersistance.Common
{
    public interface IRepository
    {
    }

    public interface IRepository<T, PKey> : IRepository where T : EntityBase
    {
        Task<T> Add(T t);
        Task<List<T>> Add(List<T> t);
        Task<T> Update(T t);

        Task Delete(T t);

        Task<T> Get(PKey key);

        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> func);

       IQueryable<T> GetQuery(Expression<Func<T, bool>> func);
        IQueryable<T> GetQuery();
    }
}