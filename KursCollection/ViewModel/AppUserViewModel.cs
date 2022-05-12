using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class AppUserViewModel
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserEmail { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastActiveDate { get; set; }
        public String UserStatus { get; set; }
        
        public AppUserViewModel() { }
        public AppUserViewModel(Models.AppUser user)
        {
            this.UserId = user.UserId;
            this.UserName = user.UserName;
            this.UserEmail = user.UserEmail;
            this.RegisterDate = user.RegisterDate;
            this.LastActiveDate = user.LastActiveDate;
            this.UserStatus = user.UserStatus;
        }
    }
}
