using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class UsersWithCommentsViewModel : AppUserViewModel
    {
        public IEnumerable<CommentViewModel> Comments { get; set; }

        public UsersWithCommentsViewModel() { }
        public UsersWithCommentsViewModel(AppUser user, IEnumerable<Comment> comments) : base(user)
        {
            Comments = comments.Select(comment => new CommentViewModel(comment));
        }
    }
}
