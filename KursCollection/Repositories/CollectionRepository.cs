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
    public class CollectionRepository : IRepository<Collection>
    {
        private ApplicationDbContext db;

        public CollectionRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Collection> GetCollectionList()
        {
            return db.Collections;
        }

        public Collection GetCollection(int id)
        {
            return db.Collections.Find(id);
        }

        public Collection Create(Collection userCollection)
        {
            db.Collections.Add(userCollection);
            return userCollection;
        }

        public Collection Update(Collection userCollection)
        {
            db.Entry(userCollection).State = EntityState.Modified;
            return userCollection;
        }

        public void Delete(int id)
        {
            Collection userCollection = db.Collections.Find(id);
            if (userCollection != null)
            {
                db.Collections.Remove(userCollection);
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

