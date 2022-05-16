using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class ItemWithCommentsLikesViewModel : ItemViewModel
    {

        public IEnumerable<CommentViewModel> Comments { get; set; }
        public IEnumerable<LikeViewModel> Likes { get; set; }

        public ItemWithCommentsLikesViewModel() { }
        public ItemWithCommentsLikesViewModel(Item item, IEnumerable<Comment> comments, IEnumerable<Like> likes) : base(item)
        {
            Comments = comments.Select(comment => new CommentViewModel(comment));
            Likes = likes.Select(like => new LikeViewModel(like));
        }
    }
}
