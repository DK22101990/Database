using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CFS.Data.IRepositories
{
    public interface IRepository : IDisposable
    {
        Task<TItem> Update<TItem>(TItem item) where TItem : class, new();

        Task<TItem> Delete<TItem>(TItem item) where TItem : class, new();

        Task<TItem> Insert<TItem>(TItem item) where TItem : class, new();

        void Save();

        IEnumerable<TItem> FindAllBy<TItem>(Expression<Func<TItem, bool>> predicate) where TItem : class, new();

        TItem FindFirstOrDefaultBy<TItem>(Expression<Func<TItem, bool>> predicate) where TItem : class, new();

        IEnumerable<TItem> FindAll<TItem>() where TItem : class, new();

        Task<List<TItem>> UpdateRange<TItem>(List<TItem> listItem) where TItem : class, new();

        bool DeleteRange<TItem>(List<TItem> listItem) where TItem : class, new();
    }
}
