using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public String CommentText { get; set; }

        public CommentViewModel(Models.Comment comment)
        {
            this.CommentId = comment.CommentId;
            this.UserId = comment.AppUserId;
            this.ItemId = comment.ItemId;
            this.CommentText = comment.CommentText;
        }
    }
}
