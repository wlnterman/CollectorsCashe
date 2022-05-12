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
        IItemService itemService;

        public CollectionService(IRepository<Collection> repository, IUserRepository<AppUser> urepository, IItemService itemService)
        {
            this.userCollectionRepository = repository;
            this.userRepository = urepository;
            this.itemService = itemService;
        }


        public IEnumerable<CollectionViewModel> GetCollectionVMList()
        {
            var collections = userCollectionRepository.GetCollectionList();
            var collectionList = collections.Select(collection => new CollectionViewModel(collection));
            return collectionList;
            //throw new NotImplementedException();
        }

        public UserWithCollectionsViewModel GetCollectionList()
        {
            var collections = userCollectionRepository.GetCollectionList();
            //var collectionList = collections.Select(collection => new CollectionViewModel(collection));
            //return collectionList;
            return new UserWithCollectionsViewModel(userRepository.GetUser(1), collections);
        }

        public IEnumerable<CollectionViewModel> GetUserCollectionVMList(int userId) //ne list!!!
        {
            var collections = userCollectionRepository.GetCollectionList();
            var userCollections = collections.Where(collection => collection.AppUserId == userId);
            var collectionList = userCollections.Select(collection => new CollectionViewModel(collection));
            return collectionList;
            //throw new NotImplementedException();
        }

        public UserWithCollectionsViewModel GetUserCollectionList(int userId) //ne list!!!  eto dlya user with col view model
        {
            var collections = userCollectionRepository.GetCollectionList();
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
            var newCollection = new Collection(collection.UserId, collection.CollectionName, collection.CollectionDescription, collection.ThemeId, collection.CollectionImageLink);
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


        public CollectionViewModel Update(CollectionViewModel item)
        {
            var collection = new Collection(item.UserId, item.CollectionName, item.CollectionDescription, item.ThemeId, item.CollectionImageLink);
            var updatedCollection = userCollectionRepository.Update(collection);
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
