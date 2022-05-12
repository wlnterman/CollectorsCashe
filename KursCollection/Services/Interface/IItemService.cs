using KursCollection.Models;
using KursCollection.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Services.Interface
{
    public interface IItemService
    {
        IEnumerable<ItemViewModel> GetItemVMList();
        IEnumerable<ItemViewModel> GetCollectionItemVMList(int id);
        CollectionWithItemsViewModel GetCollectionItemList(int id);//added
        IEnumerable<Item> GetCollectionItems(int id);
        ItemViewModel GetItem(int id);
        ItemViewModel Create(ItemViewModel collection);
        ItemViewModel Update(ItemViewModel collection);
        void Delete(int id);
        void Save();
    }
}
