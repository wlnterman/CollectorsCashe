using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [Required]
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public String CommentText { get; set; }
        public DateTime CommentDate { get; set; }

        public Comment(int appUserId, int itemId, string commentText, DateTime commentDate)
        {
            AppUserId = appUserId;
            ItemId = itemId;
            CommentText = commentText;
            CommentDate = commentDate;
        }
    }
}
