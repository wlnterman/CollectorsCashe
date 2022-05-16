using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{

    public class CollectionWithItemCLViewModel : CollectionViewModel
    {
        public ItemWithCommentsLikesViewModel Items { get; set; }

        public CollectionWithItemCLViewModel() { }
        public CollectionWithItemCLViewModel(Collection collection, Item item, IEnumerable<Comment> comments, IEnumerable<Like> likes) : base(collection)
        {
            Items = new ItemWithCommentsLikesViewModel(item, comments, likes);
        }
    }
}
