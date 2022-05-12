using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Repositories.Interface
{
    public interface IUserRepository<T> : IDisposable
    where T : class
    {
        IEnumerable<T> GetUserList();
        T GetUser(int id);
        AppUser Create(T item);
        AppUser Update(T item);
        void Delete(int id);
        void Save();
    }
}
