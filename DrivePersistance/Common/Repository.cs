using DriveEntities.Entities;
using DriveEntityFramworkcore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DrivePersistance.Common
{
    public class Repository<T, PKey> : IRepository<T, PKey> where T : EntityBase
    {
        private readonly DriveDbContext _driveDbContext;
        internal DbSet<T> dbSet;
        public Repository(DriveDbContext driveDbContext)
        {
           _driveDbContext = driveDbContext;
            dbSet = driveDbContext.Set<T>();
        }
        public async Task<T> Add(T t)
        {
            _driveDbContext.Add<T>(t);
           await _driveDbContext.SaveChangesAsync();
            return t;
        }

        public async Task Delete(T t)
        {
            _driveDbContext.Remove<T>(t);
            await _driveDbContext.SaveChangesAsync();
        }

        public async Task<T> Get(PKey key)
        {
          return await  _driveDbContext.FindAsync<T>(key);
        }

        public async  Task<IEnumerable<T>> Get(Expression<Func<T,bool>> func)
        {
            return  await dbSet.Where(func).AsNoTracking().ToListAsync();
        }

        public IQueryable<T> GetQuery(Expression<Func<T,bool>> func)
        {
            return dbSet.Where(func);
        }

        public IQueryable<T> GetQuery()
        {
            return dbSet;
        }

        public async Task<T> Update(T t)
        {
            dbSet.Attach(t);
            _driveDbContext.Entry(t).State = EntityState.Modified;
           await _driveDbContext.SaveChangesAsync();
            return t;
        }

    }
}