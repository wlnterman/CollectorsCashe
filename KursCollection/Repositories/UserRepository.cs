using KursCollection.Data;
using KursCollection.Models;
using KursCollection.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Repositories
{

    public class UserRepository : IUserRepository<AppUser>
    {
        private ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<AppUser> GetUserList()
        {
            return db.AppUsers;
        }

        public AppUser GetUser(int id)
        {
            return db.AppUsers.Find(id);
        }

        public AppUser Create(AppUser user)
        {
            db.AppUsers.Add(user);
            return user;
        }

        public AppUser Update(AppUser user)
        {
            db.Entry(user).State = EntityState.Modified;
            return user;
        }

        public void Delete(int id)
        {
            AppUser user = db.AppUsers.Find(id);
            if (user != null)
            {
                db.AppUsers.Remove(user);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
