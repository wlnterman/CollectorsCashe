using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Repositories.Interface
{
    public interface IItemRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetItemList();
        T GetItem(int id);
        Item Create(T item);
        Item Update(T item);
        void Delete(int id);
        void Save();
    }
}
