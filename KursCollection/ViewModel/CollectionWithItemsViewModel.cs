using KursCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.ViewModel
{
    public class CollectionWithItemsViewModel : CollectionViewModel
    {
        public IEnumerable<ItemViewModel> Items { get; set; }

        public CollectionWithItemsViewModel() { }
        public CollectionWithItemsViewModel(Collection collection, IEnumerable<Item> items):base(collection)
        {
            Items = items.Select(item => new ItemViewModel(item));
        }
    }
}
