using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Repositories.Interface
{
    public interface ICommentRepository<T> : IDisposable
       where T : class
    {
        IEnumerable<T> GetCommentList();
        T GetComment(int id);
        Comment Create(T comment);
        Comment Update(T comment);
        void Delete(int id);
        void Save();
    }
}
