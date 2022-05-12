using KursCollection.Models;
using KursCollection.Repositories.Interface;
using KursCollection.Services.Interface;
using KursCollection.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Services
{
    public class ItemService : IItemService
    {
        IItemRepository<Item> itemRepository;
        IRepository<Collection> collectionRepository;

        public ItemService(IRepository<Collection> collectionRepository, IItemRepository<Item> itemRrepository)
        {
            this.collectionRepository = collectionRepository;
            this.itemRepository = itemRrepository;
        }


        public IEnumerable<ItemViewModel> GetItemVMList()
        {
            var items = itemRepository.GetItemList();
            var itemList = items.Select(item => new ItemViewModel(item));
            return itemList;
        }

        public IEnumerable<ItemViewModel> GetCollectionItemVMList(int collectionId)
        {
            var items = itemRepository.GetItemList();
            var useritems = items.Where(useritem => useritem.CollectionId == collectionId);
            var itemList = useritems.Select(item => new ItemViewModel(item));
            return itemList;
        }

        public CollectionWithItemsViewModel GetCollectionItemList(int collectionId)
        {
            var items = itemRepository.GetItemList();
            var useritems = items.Where(useritem => useritem.CollectionId == collectionId);
            //var itemList = useritems.Select(item => new ItemViewModel(item));
            return new CollectionWithItemsViewModel(collectionRepository.GetCollection(collectionId) , useritems);
        }

        public IEnumerable<Item> GetCollectionItems(int collectionId)  ///eto dlya col with items view model
        {
            var items = itemRepository.GetItemList();
            var useritems = items.Where(useritem => useritem.CollectionId == collectionId);
            //var itemList = useritems.Select(item => new ItemViewModel(item));
            return useritems;
        }


        public ItemViewModel GetItem(int id)
        {
            return new ItemViewModel(itemRepository.GetItem(id));
        }


        public ItemViewModel Create(ItemViewModel createdItem)
        {
            var newItem = new Item(createdItem.CollectionId, createdItem.ItemName,
                createdItem.ItemInt1, createdItem.ItemInt2, createdItem.ItemInt3,
                createdItem.ItemStr1, createdItem.ItemStr2, createdItem.ItemStr3,
                createdItem.ItemTxt1, createdItem.ItemTxt2, createdItem.ItemTxt3,
                createdItem.ItemDate1, createdItem.ItemDate2, createdItem.ItemDate3,
                createdItem.ItemCheckBox1, createdItem.ItemCheckBox2, createdItem.ItemCheckBox3);
            var savedItem = itemRepository.Create(newItem);
            itemRepository.Save();
            return new ItemViewModel(savedItem);
        }

        public ItemViewModel Update(ItemViewModel updatedItem)
        {
            var newItem = new Item(updatedItem.CollectionId, updatedItem.ItemName, 
                updatedItem.ItemInt1, updatedItem.ItemInt2, updatedItem.ItemInt3,
                updatedItem.ItemStr1, updatedItem.ItemStr2, updatedItem.ItemStr3,
                updatedItem.ItemTxt1, updatedItem.ItemTxt2, updatedItem.ItemTxt3,
                updatedItem.ItemDate1, updatedItem.ItemDate2, updatedItem.ItemDate3,
                updatedItem.ItemCheckBox1, updatedItem.ItemCheckBox2, updatedItem.ItemCheckBox3);
            var savedItem = itemRepository.Update(newItem);
            itemRepository.Save();
            return new ItemViewModel(savedItem);
        }

        public void Delete(int id)
        {
            itemRepository.Delete(id);
            itemRepository.Save();
        }


        public void Save()
        {
            itemRepository.Save();
        }
    }
}
