using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Repositories.Interface
{
    public interface IRepository<T> : IDisposable
         where T : class
    {
        IEnumerable<T> GetCollectionList();
        T GetCollection(int id);
        Collection Create(T item);
        Collection Update(T item);
        void Delete(int id);
        void Save();
    }
}
