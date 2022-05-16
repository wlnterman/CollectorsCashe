using KursCollection.Data;
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
        private ApplicationDbContext db;
        IUserRepository<AppUser> userRepository;
        IItemRepository<Item> itemRepository;
        IRepository<Collection> collectionRepository;
        ICommentRepository<Comment> commentRepository;

        public ItemService(ApplicationDbContext db, IUserRepository<AppUser> urepository, IRepository<Collection> collectionRepository, IItemRepository<Item> itemRrepository, ICommentRepository<Comment> commentRepository)
        {
            this.db = db;
            this.userRepository = urepository;
            this.collectionRepository = collectionRepository;
            this.itemRepository = itemRrepository;
            this.commentRepository = commentRepository;
        }

        public IEnumerable<ItemViewModel> GetiIemLast5VMList()
        {

            //top 3 latestadded
            var items =  itemRepository.GetItemList().OrderByDescending(i => i.ItemId).Take(6);
            var itemList = items.Select(item => new ItemViewModel(item));
            return itemList;
            //throw new NotImplementedException();
        }

        public IEnumerable<ItemViewModel> GetItemVMList()
        {
            var items = itemRepository.GetItemList().OrderBy(i => i.ItemId);
            var itemList = items.Select(item => new ItemViewModel(item));
            return itemList;
        }

        public IEnumerable<ItemViewModel> GetCollectionItemVMList(int collectionId)
        {
            var items = itemRepository.GetItemList().OrderBy(i => i.ItemId);
            var useritems = items.Where(useritem => useritem.CollectionId == collectionId);
            var itemList = useritems.Select(item => new ItemViewModel(item));
            return itemList;
        }

        public CollectionWithItemsViewModel GetCollectionItemList(int collectionId)
        {
            var items = itemRepository.GetItemList().OrderBy(i => i.ItemId);
            var useritems = items.Where(useritem => useritem.CollectionId == collectionId);
            //var itemList = useritems.Select(item => new ItemViewModel(item));
            return new CollectionWithItemsViewModel(collectionRepository.GetCollection(collectionId) , useritems);
        }

        public IEnumerable<Item> GetCollectionItems(int collectionId)  ///eto dlya col with items view model
        {
            var items = itemRepository.GetItemList().OrderBy(i => i.ItemId);
            var useritems = items.Where(useritem => useritem.CollectionId == collectionId);
            //var itemList = useritems.Select(item => new ItemViewModel(item));
            return useritems;
        }

        public CollectionWithItemsViewModel GetOneCollectionItem(int id)  ///eto dlya col with items view model
        {

            var items = itemRepository.GetItemList();
            var collectionitems = items.Where(useritem => useritem.ItemId == id);
            Item collectionitem = collectionitems.First();
            //var itemList = useritems.Select(item => new ItemViewModel(item));
            return new CollectionWithItemsViewModel(collectionRepository.GetCollection(collectionitem.CollectionId), collectionitems);
        }


        public ItemViewModel GetItem(int id)
        {
            return new ItemViewModel(itemRepository.GetItem(id));
        }

        public string GetUserNameByID(int id)
        {
            AppUser user = userRepository.GetUser(id);// _context.AppUsers.FirstOrDefault(u => u.UserId == id);
            return user.UserName;
        }

        public CollectionWithItemCLViewModel GetItemWCLVM(int id) //remade from ItemWithCommentsLikesViewModel to CollectionWithItemCLViewModel
        {
            var likes = db.Likes;                                                                       ////add like repository?
            var itemlikes = likes.Where(like => like.ItemId == id);
            var comments = commentRepository.GetCommentList().OrderBy(i => i.CommentId);
            var itemcomments = comments.Where(comment => comment.ItemId == id);

            //var result = new ItemWithCommentsLikesViewModel(itemRepository.GetItem(id), itemcomments, itemlikes);
            //var list2 = new List<CommentViewModel>();
            //foreach (var elem in result.Comments)
            //{
            //    var tmp = GetUserNameByID(elem.UserId);
            //    elem.UserName = tmp;
            //    list2.Add(elem);
            //}
            //result.Comments = list2;
            //return result;
            var item = itemRepository.GetItem(id);
            var result = new CollectionWithItemCLViewModel(collectionRepository.GetCollection(item.CollectionId), item, itemcomments, itemlikes);
            var list2 = new List<CommentViewModel>();
            foreach (var elem in result.Items.Comments)
            {
                var tmp = GetUserNameByID(elem.UserId);
                elem.UserName = tmp;
                list2.Add(elem);
            }
            result.Items.Comments = list2;
            return result;            
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
            newItem.ItemId = updatedItem.ItemId;
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
