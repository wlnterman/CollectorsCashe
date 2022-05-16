using KursCollection.Data;
using KursCollection.Models;
using KursCollection.Repositories.Interface;
using KursCollection.Services.Interface;
using KursCollection.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursCollection.Controllers
{
    [Route("collection/{collectionId:int}/items/[action]")]
    public class ItemController : Controller
    {

        IItemService itemService;
        IUserRepository<AppUser> userRepository;
        private readonly ApplicationDbContext _context;

        public ItemController(IItemService itemService, IUserRepository<AppUser> urepository,
            ApplicationDbContext db)
        {
            this.itemService = itemService;
            this.userRepository = urepository;
            _context = db;
        }

        public AppUser getLocalUser()
        {
            var currentUserEmail = HttpContext.User.Identity.Name;
            AppUser user = _context.AppUsers.FirstOrDefault(u => u.UserEmail == currentUserEmail);
            return user;
        }

        

        public AppUser findCollectionOwner(int collectionId)
        {
            Collection collection = _context.Collections.FirstOrDefault(u => u.CollectionId == collectionId);
            AppUser user = _context.AppUsers.FirstOrDefault(u => u.UserId == collection.AppUserId);
            return user;
        }

        public bool checkOwnerRights(int collectionId)
        {
            Collection collection = _context.Collections.FirstOrDefault(u => u.CollectionId == collectionId);
            AppUser user = getLocalUser();
            if (user == null)
            {
                return false;
            }
            else if (user.UserId != collection.AppUserId)
            {
                if (!user.IsAdmin)
                   return false;
            }
                return true;
        }

        //[HttpPost("Posts/Details/{PostId}")]
        [HttpPost]
        [Route("{id:int}/addcomment")]
        public async Task<IActionResult> CreateComment(int collectionId, int id, CommentViewModel commentViewModel)
        {
            if (ModelState.IsValid)
            {
                //findCollectionOwner(collectionId).UserId
                var newComment = new Comment(getLocalUser().UserId, id, commentViewModel.CommentText, DateTime.Now);
                 _context.Comments.Add(newComment);
                 _context.SaveChanges();
                return RedirectToAction("ShowOneItem", new { collectionId = collectionId, id = id });
                //return View("Details", new Comment { PostId = comment.PostId });
            }
            return RedirectToAction("ShowOneItem", new { collectionId = collectionId, id = id });                                               //////add await?
        }

        [HttpGet]
        public ActionResult CreateItem(int collectionId)
        {
            return View(itemService.GetCollectionItemList(collectionId));
        }

        [HttpGet]
        public ActionResult ShowAllItems()
        {
            return View("ItemViewer", itemService.GetItemVMList());
        }

        //[HttpGet]
        //[Route("")]
        //public ActionResult ShowCollectionItems(int collectionId)
        //{
            
        //    //var currentUserEmail = HttpContext.User.Identity.Name;
        //    return View("ItemViewer", itemService.GetCollectionItemList(collectionId));
        //}

        [HttpGet]
        [Route("")]
        public ActionResult ShowCollectionItemsCWI(int collectionId)
        {
            ViewBag.OwnerRights = checkOwnerRights(collectionId);
            //var currentUserEmail = HttpContext.User.Identity.Name;
            return View("ItemViewer", itemService.GetCollectionItemList(collectionId));
        }

        public string GetUserNameByID(int id)
        {
            AppUser user = userRepository.GetUser(id);// _context.AppUsers.FirstOrDefault(u => u.UserId == id);
            return user.UserName;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult ShowOneItem(int collectionId, int id)
        {
            ViewBag.OwnerRights = checkOwnerRights(collectionId);

            var like = CheckUserLike(id);
            if (like == null)
                ViewBag.HasUserLike = false;
            else
                ViewBag.HasUserLike = true;

            var list = itemService.GetItemWCLVM(id);
            //var list2 = new List<CommentViewModel>();
            //foreach (var elem in list.Comments)
            //{
            //    var tmp = GetUserNameByID(elem.UserId);
            //    elem.UserName = tmp;
            //    list2.Add(elem);
            //}
            //list.Comments = list2;


            return View("OneItem", list);
            //return View("OneItem", itemService.GetItem(id));
        }


        [HttpPost]
        public ActionResult Create(ItemViewModel itemViewModel, int collectionId)
        {
            if (ModelState.IsValid)
            {
                itemViewModel.CollectionId = collectionId;
                var createdItem = itemService.Create(itemViewModel);
                return RedirectToAction("ShowCollectionItemsCWI", new { collectionId = collectionId });
            }
            return RedirectToAction("ShowCollectionItemsCWI", new { collectionId = collectionId });
            //return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("{id:int}/edit1/")]
        public ActionResult EditItem(int id)
        {
            //var tmp = _context.Themes.ToList();                       //переделать на теги
            //ViewBag.Themes = new List<Theme>(tmp);
            return View(itemService.GetOneCollectionItem(id)); 
            //return View(itemService.GetItem(id));
        }

        [HttpPost]
        [Route("{id:int}/edit")]
        public ActionResult Edit(ItemViewModel itemViewModel, int collectionId)
        {
            if (ModelState.IsValid)
            {
                itemService.Update(itemViewModel);
                return RedirectToAction("ShowCollectionItemsCWI", new { collectionId = collectionId });
            }
            return RedirectToAction("ShowCollectionItemsCWI", new { collectionId = collectionId });
        }

        [HttpGet]
        public async Task<ActionResult> DeleteItems(int[] selectedIds)//checkedArray)
        { 
            foreach (int item in selectedIds)
            {
                itemService.Delete(item);
                itemService.Save();
            }
            return NoContent();
        }

        public Like CheckUserLike(int itemId)
        {
            AppUser user = getLocalUser();
            var likes = _context.Likes;
            var itemlikes = likes.Where(like => like.ItemId == itemId);
            Like userlike = null;
            if (user == null)
            {
                userlike = itemlikes.FirstOrDefault(like => like.AppUserId == -1);
            }
            else
            {
                userlike = itemlikes.FirstOrDefault(like => like.AppUserId == user.UserId);
            }
            
            return userlike;

        }

        [HttpPost]
        public async Task<ActionResult> Like(int itemId)//checkedArray)
        {
            Like userlike = CheckUserLike(itemId);
            if(userlike == null)
            {
                userlike = new Like(getLocalUser().UserId, itemId);
                _context.Likes.Add(userlike);
            }
            else
            {
                _context.Likes.Remove(userlike);
            }
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public ActionResult Edit(ItemViewModel itemViewModel)
        {
            if (ModelState.IsValid)
            {
                itemService.Update(itemViewModel);
                return RedirectToAction("Index");
            }
            return View(itemViewModel);
        }

        [Route("{id:int}/delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            itemService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}")]
        public ActionResult GetItem(int id)
        {
            return View(itemService.GetItem(id));
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            //return RedirectToAction("Edit", roomService.GetRoom(id));
            return View(itemService.GetItem(id));
        }
    }
}
