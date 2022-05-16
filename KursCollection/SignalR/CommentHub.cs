using KursCollection.Data;
using KursCollection.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.SignalR
{
    public class CommentHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public CommentHub(ApplicationDbContext db)
        {
            _context = db;
        }


        //string groupname = "cats";
        public async Task Enter( int itemId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, itemId.ToString());
            await Clients.Group(itemId.ToString()).SendAsync("Notify", $"{itemId.ToString()} вошел в чат");
        }
        public async Task Send(int itemId, string message)
        {
            var userEmail = Context.GetHttpContext().User.Identity.Name;
            AppUser user = _context.AppUsers.FirstOrDefault(u => u.UserEmail == userEmail);
            var now = DateTime.Now;
            var newComment = new Comment(user.UserId, itemId, message, now);
            _context.Comments.Add(newComment);
            _context.SaveChanges();
            await Clients.Group(itemId.ToString()).SendAsync("Receive", user.UserName, message, now);
        }
    }
}
