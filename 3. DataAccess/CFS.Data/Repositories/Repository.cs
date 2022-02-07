using CFS.Data.Context;
using CFS.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.Repositories
{
    public abstract class Repository : IRepository
    {
        protected Repository(CFSContext context)
        {
            Context = context;
        }

        public CFSContext Context { get; set; }

        public void Dispose()
        {
            Context.Dispose();
        }

        public async Task<TItem> Update<TItem>(TItem item) where TItem : class, new()
        {
            return await PerformAction(item, EntityState.Modified);
        }

        public async Task<TItem> Delete<TItem>(TItem item) where TItem : class, new()
        {
            return await PerformAction(item, EntityState.Deleted);
        }

        public async Task<TItem> Insert<TItem>(TItem item) where TItem : class, new()
        {
            return await PerformAction(item, EntityState.Added);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public IEnumerable<T> Select<T>() where T : class
        {
            return Context.Set<T>();
        }

        public IEnumerable<TItem> FindAllBy<TItem>(Expression<Func<TItem, bool>> predicate) where TItem : class, new()
        {
            IEnumerable<TItem> query = Context.Set<TItem>().Where(predicate).ToList();
            return query;
        }

        public TItem FindFirstOrDefaultBy<TItem>(Expression<Func<TItem, bool>> predicate) where TItem : class, new()
        {
            var query = Context.Set<TItem>().Where(predicate).FirstOrDefault();
            return query;
        }

        public IEnumerable<TItem> FindAll<TItem>() where TItem : class, new()
        {
            IEnumerable<TItem> query = Context.Set<TItem>().ToList();
            return query;
        }

        public async Task<List<TItem>> UpdateRange<TItem>(List<TItem> listItem) where TItem : class, new()
        {
            foreach (var item in listItem) Context.Entry(item).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return listItem;
        }

        public bool DeleteRange<TItem>(List<TItem> listItem) where TItem : class, new()
        {
            try
            {
                foreach (var item in listItem) Context.Entry(item).State = EntityState.Deleted;
                Context.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        protected virtual async Task<TItem> PerformAction<TItem>(TItem item, EntityState entityState)
            where TItem : class, new()
        {
            Context.Entry(item).State = entityState;
            await Context.SaveChangesAsync();
            return item;
        }
        public async Task<List<TItem>> BulkInsert<TItem>(List<TItem> listItem) where TItem : class, new()
        {
            foreach (var item in listItem) Context.Entry(item).State = EntityState.Added;
            await Context.SaveChangesAsync();
            return listItem;
        }
    }
}
