using KursCollection.Models;
using KursCollection.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Services.Interface
{
    public interface ICollectionService
    {
        IEnumerable<CollectionViewModel> GetCollectionVMList();
        UserWithCollectionsViewModel GetCollectionList();
        IEnumerable<CollectionViewModel> GetUserCollectionVMList(int id);
        UserWithCollectionsViewModel GetUserCollectionList(int id);//added
        CollectionViewModel GetCollection(int id);
        CollectionViewModel Create(CollectionViewModel collection);
        CollectionViewModel Update(CollectionViewModel collection);
        void Delete(int id);
        void Save();
    }
}
