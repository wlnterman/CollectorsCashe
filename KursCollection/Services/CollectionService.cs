using KursCollection.Models;
using KursCollection.Repositories.Interface;
using KursCollection.Services.Interface;
using KursCollection.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace KursCollection.Services
{
    public class CollectionService : ICollectionService
    {
        IRepository<Collection> userCollectionRepository;
        IUserRepository<AppUser> userRepository;
        IRepository<Collection> collectionRepository;
        IItemRepository<Item> itemRepository;
        IItemService itemService;

        public CollectionService(IRepository<Collection> repository, IUserRepository<AppUser> urepository, IRepository<Collection> collectionRepository, IItemRepository<Item> itemRrepository, IItemService itemService)
        {
            this.userCollectionRepository = repository;
            this.userRepository = urepository;
            this.collectionRepository = collectionRepository;
            this.itemRepository = itemRrepository;
            this.itemService = itemService;
        }

        public IEnumerable<CollectionWithItemsViewModel> GetCollectionTop3VMList()
        {
            List<CollectionWithItemsViewModel> result = new List<CollectionWithItemsViewModel>();
            var collections = userCollectionRepository.GetCollectionList().OrderBy(i => i.CollectionId);
            var items = itemRepository.GetItemList();
            foreach(var elem in collections)
            {
                var useritems = items.Where(useritem => useritem.CollectionId == elem.CollectionId);
                var tmp = new CollectionWithItemsViewModel(collectionRepository.GetCollection(elem.CollectionId), useritems);
                result.Add(tmp);
            }
            var result3 = result.OrderByDescending(i => i.Items.Count()).Take(3);
            //var result3 = result.OrderByDescending(i => i.CollectionId).Take(3);
            return result3;
            //top 3 latestadded//var collections = userCollectionRepository.GetCollectionList().OrderByDescending(i => i.CollectionId).Take(3);//.Where(collection => collection.CollectionId == 1);
            //var collectionList = collections.Select(collection => new CollectionViewModel(collection));
            //return collectionList;
            //throw new NotImplementedException();
        }

        public IEnumerable<CollectionViewModel> GetCollectionVMList()
        {
            var collections = userCollectionRepository.GetCollectionList().OrderBy(i => i.CollectionId);
            var collectionList = collections.Select(collection => new CollectionViewModel(collection));
            return collectionList;
            //throw new NotImplementedException();
        }

        public UserWithCollectionsViewModel GetCollectionList()
        {
            var collections = userCollectionRepository.GetCollectionList().OrderBy(i => i.CollectionId);
            //var collectionList = collections.Select(collection => new CollectionViewModel(collection));
            //return collectionList;
            return new UserWithCollectionsViewModel(userRepository.GetUser(1), collections);
        }

        public IEnumerable<CollectionViewModel> GetUserCollectionVMList(int userId) //ne list!!!
        {
            var collections = userCollectionRepository.GetCollectionList().OrderBy(i => i.CollectionId);
            var userCollections = collections.Where(collection => collection.AppUserId == userId);
            var collectionList = userCollections.Select(collection => new CollectionViewModel(collection));
            return collectionList;
            //throw new NotImplementedException();
        }

        public UserWithCollectionsViewModel GetUserCollectionList(int userId) //ne list!!!  eto dlya user with col view model
        {
            var collections = userCollectionRepository.GetCollectionList().OrderBy(i => i.CollectionId);
            var userCollections = collections.Where(collection => collection.AppUserId == userId);
            //var collectionList = userCollections.Select(collection => new CollectionViewModel(collection));
            return new UserWithCollectionsViewModel(userRepository.GetUser(userId), userCollections);
        }

        public CollectionWithItemsViewModel GetUserCollectionsWithItems(int id)
        {
            return new CollectionWithItemsViewModel(userCollectionRepository.GetCollection(id), itemService .GetCollectionItems(id));
        }


        public CollectionViewModel GetCollection(int id)
        {
            return new CollectionViewModel(userCollectionRepository.GetCollection(id));
            //throw new NotImplementedException();
        }


        public CollectionViewModel Create(CollectionViewModel collection)
        {
            var newCollection = new Collection(
                collection.UserId, collection.CollectionName, collection.CollectionDescription, collection.ThemeId, collection.CollectionImageLink,
                collection.ItemInt1, collection.ItemInt2, collection.ItemInt3,
                collection.ItemStr1, collection.ItemStr2, collection.ItemStr3,
                collection.ItemTxt1, collection.ItemTxt2, collection.ItemTxt3,
                collection.ItemDate1, collection.ItemDate2, collection.ItemDate3,
                collection.ItemCheckBox1, collection.ItemCheckBox2, collection.ItemCheckBox3);
            var createdCollection = userCollectionRepository.Create(newCollection);
            userCollectionRepository.Save();
            return new CollectionViewModel(createdCollection);
            // new NotImplementedException();
        }


        //public RoomViewModel CreateRoom(String roomName, int userCount)
        //{
        //    var room = new Room(roomName, userCount);

        //    return new RoomViewModel();
        //}


        public CollectionViewModel Update(CollectionViewModel collection)
        {
            var newcollection = new Collection(collection.UserId, collection.CollectionName, collection.CollectionDescription, collection.ThemeId, collection.CollectionImageLink,
                collection.ItemInt1, collection.ItemInt2, collection.ItemInt3,
                collection.ItemStr1, collection.ItemStr2, collection.ItemStr3,
                collection.ItemTxt1, collection.ItemTxt2, collection.ItemTxt3,
                collection.ItemDate1, collection.ItemDate2, collection.ItemDate3,
                collection.ItemCheckBox1, collection.ItemCheckBox2, collection.ItemCheckBox3);
            newcollection.CollectionId = collection.CollectionId;
            var updatedCollection = userCollectionRepository.Update(newcollection);
            userCollectionRepository.Save();
            return new CollectionViewModel(updatedCollection);
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            userCollectionRepository.Delete(id);
            userCollectionRepository.Save();
            //throw new NotImplementedException();
        }


        public void Save()
        {
            userCollectionRepository.Save();
            //throw new NotImplementedException();
        }
    }
}
