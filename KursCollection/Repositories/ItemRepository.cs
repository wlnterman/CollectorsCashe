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
    public class ItemRepository : IItemRepository<Item>
    {
        private ApplicationDbContext db;

        public ItemRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Item> GetItemList()
        {
            return db.Items;
        }

        public Item GetItem(int id)
        {
            return db.Items.Find(id);
        }

        public Item Create(Item userItem)
        {
            db.Items.Add(userItem);
            return userItem;
        }

        public Item Update(Item userItem)
        {
            db.Entry(userItem).State = EntityState.Modified;
            return userItem;
        }

        public void Delete(int id)
        {
            Item userItem = db.Items.Find(id);
            if (userItem != null)
            {
                db.Items.Remove(userItem);
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
