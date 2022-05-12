using KursCollection.Data;
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
        private readonly ApplicationDbContext _context;

        public ItemController(IItemService itemService,
            ApplicationDbContext db)
        {
            this.itemService = itemService;
            _context = db;
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

        [HttpGet]
        [Route("")]
        public ActionResult ShowCollectionItems(int collectionId)
        {
            var currentUserEmail = HttpContext.User.Identity.Name;
            return View("ItemViewer", itemService.GetCollectionItemList(collectionId));
        }

        [HttpGet]
        [Route("")]
        public ActionResult ShowCollectionItemsCWI(int collectionId)
        {
            var currentUserEmail = HttpContext.User.Identity.Name;
            return View("ItemViewer", itemService.GetCollectionItemList(collectionId));
        }


        [HttpPost]
        public ActionResult Create(ItemViewModel itemViewModel, int collectionId)
        {
            if (ModelState.IsValid)
            {
                itemViewModel.CollectionId = collectionId;//getUserLocalId();                 // -------- fiiiiiiiiiiiiiiiiiiiiix-----------------
                var createdItem = itemService.Create(itemViewModel);
                //return RedirectToAction("ShowUserCollections");
                return RedirectToAction("ShowCollectionItems", new { collectionId = collectionId });
            }
            return RedirectToAction("ShowCollectionItems", new { collectionId = collectionId });
            //return RedirectToAction("Index");
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
