using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Models
{
    public class AppUser //fix
    {
        [Key]
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserEmail { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastActiveDate { get; set; }
        public String UserStatus { get; set; }
        public bool IsAdmin { get; set; }
        public bool DarkTheme { get; set; }

        public List<Collection> Collections { get; set; } = new List<Collection>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Like> Likes { get; set; } = new List<Like>();

        public AppUser() { }
        public AppUser(String userName, String userEmail, DateTime registerDate, DateTime lastActiveDate, String userStatus, bool isAdmin, bool darkTheme)
        {
            this.UserName = userName;
            this.UserEmail = userEmail;
            this.RegisterDate = registerDate;
            this.LastActiveDate = lastActiveDate;
            this.UserStatus = userStatus;
            this.IsAdmin = isAdmin;
            this.DarkTheme = darkTheme;
        }
    }
}
