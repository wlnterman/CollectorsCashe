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
    public class CommentRepository : ICommentRepository<Comment>
    {
        private ApplicationDbContext db;

        public CommentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Comment> GetCommentList()
        {
            return db.Comments;
        }

        public Comment GetComment(int id)
        {
            return db.Comments.Find(id);
        }

        public Comment Create(Comment userComment)
        {
            db.Comments.Add(userComment);
            return userComment;
        }

        public Comment Update(Comment userComment)
        {
            db.Entry(userComment).State = EntityState.Modified;
            return userComment;
        }

        public void Delete(int id)
        {
            Comment userComment = db.Comments.Find(id);
            if (userComment != null)
            {
                db.Comments.Remove(userComment);
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
