using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Database;

using Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Repository(ApplicationDbContext applicationDbContext) => this.ApplicationDbContext = applicationDbContext;

        protected ApplicationDbContext ApplicationDbContext { get; set; }

        // S Accessors
        public IQueryable<TEntity> Get() => this.ApplicationDbContext.Set<TEntity>().AsNoTracking();

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate) => this.ApplicationDbContext.Set<TEntity>().Where(predicate).AsNoTracking();

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate) => await this.ApplicationDbContext.Set<TEntity>().FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<TEntity>> GetAsync() => await this.ApplicationDbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<TEntity> GetAsync(Guid id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);
        public async Task<TEntity> GetAsync(int id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);

        public async Task<ICollection<TEntity>> GetOrderByAsync() => await this.Get().OrderBy(t => t).ToListAsync();

        public async Task<ICollection<TEntity>> GetOrderByDescendingAsync() => await this.Get().OrderByDescending(t => t).ToListAsync();

        public async Task<TEntity> FindAsync(int id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);

        public async Task<bool> SuccessAsync(int id) => await this.FindAsync(id) != null;

        public async Task<bool> SuccessAsync(Expression<Func<TEntity, bool>> predicate) => (await this.ApplicationDbContext.Set<TEntity>().FirstOrDefaultAsync(predicate)) != null;
        // E Accessors

        // S Mutators
        public async Task PostAsync(TEntity entity) => await this.ApplicationDbContext.Set<TEntity>().AddAsync(entity);
        public async Task PostRangeAsync(TEntity entity) => await this.ApplicationDbContext.Set<TEntity>().AddRangeAsync(entity);

        public void Put(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().Update(entity);
        public void PutRange(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().UpdateRange(entity);

        public void Delete(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().Remove(entity);
        public void DeleteRange(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().RemoveRange(entity);
        // E Mutators
    }

    public class Repository<TEntity, TEntityID> : IRepository<TEntity, TEntityID> where TEntity : class where TEntityID : struct
    {
        public Repository(ApplicationDbContext applicationDbContext) => this.ApplicationDbContext = applicationDbContext;

        protected ApplicationDbContext ApplicationDbContext { get; set; }

        // S Accessors
        public IQueryable<TEntity> Get() => this.ApplicationDbContext.Set<TEntity>().AsNoTracking();

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate) => this.ApplicationDbContext.Set<TEntity>().Where(predicate).AsNoTracking();

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate) => await this.ApplicationDbContext.Set<TEntity>().FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<TEntity>> GetAsync() => await this.ApplicationDbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        //// Todo: Check???
        //public async Task<TEntity> GetAsync(Guid id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);
        //// Todo: Check???
        //public async Task<TEntity> GetAsync(int id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);
        // Todo: Check??????????????
        public async Task<TEntity> GetAsync(TEntityID id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);

        public async Task<ICollection<TEntity>> GetOrderByAsync() => await this.Get().OrderBy(t => t).ToListAsync();

        public async Task<ICollection<TEntity>> GetOrderByDescendingAsync() => await this.Get().OrderByDescending(t => t).ToListAsync();

        public async Task<TEntity> FindAsync(int id) => await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);

        public async Task<bool> SuccessAsync(int id) => await this.FindAsync(id) != null;

        public async Task<bool> SuccessAsync(Expression<Func<TEntity, bool>> predicate) => (await this.ApplicationDbContext.Set<TEntity>().FirstOrDefaultAsync(predicate)) != null;
        // E Accessors

        // S Mutators
        public async Task PostAsync(TEntity entity) => await this.ApplicationDbContext.Set<TEntity>().AddAsync(entity);
        public async Task PostRangeAsync(TEntity entity) => await this.ApplicationDbContext.Set<TEntity>().AddRangeAsync(entity);

        public void Put(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().Update(entity);
        public void PutRange(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().UpdateRange(entity);

        public void Delete(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().Remove(entity);
        public void DeleteRange(TEntity entity) => this.ApplicationDbContext.Set<TEntity>().RemoveRange(entity);
        // E Mutators
    }
}
