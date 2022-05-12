using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursCollection.Data;
using KursCollection.Models;
using KursCollection.Repositories;
using KursCollection.Repositories.Interface;
using KursCollection.Services;
using KursCollection.Services.Interface;
using KursCollection.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



using System.Web;
using System.Configuration;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Text.RegularExpressions;
using System.Drawing;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Http;

namespace KursCollection.Controllers
{
    [Route("[controller]")]
    public class CollectionController : Controller
    {
        ICollectionService collectionService;
        private readonly ApplicationDbContext _context;
        private const string Tags = "backend_PhotoAlbum";

        public CollectionController( ICollectionService collectionService,
            ApplicationDbContext db)
        {
            this.collectionService = collectionService;
            _context = db;
        }


        public int getUserLocalId()
        {
            var currentUserEmail = HttpContext.User.Identity.Name;
            AppUser user = _context.AppUsers.FirstOrDefault(u => u.UserEmail == currentUserEmail);
            return user.UserId;
        }


        //[HttpPost]
        [HttpGet]
        [Route("{id:int}/create1")]
        public ActionResult CreateCollection(int id)
        {
            var tmp = _context.Themes.ToList();
            ViewBag.Themes = new List<Theme>(tmp);
            return View(collectionService.GetUserCollectionList(id));
        }

        [HttpGet]
        [Route("all")]
        public ActionResult ShowAllCollections()
        {
            return View("CollectionViewer", collectionService.GetCollectionVMList());
        }

        //[HttpGet]

        //[Route("{id:int?}")]
        //public ActionResult ShowUserCollections(int? id)
        //{
        //    if (id == -1)
        //        id = getUserLocalId();
        //    int grantedId = (int)(id ?? 0);
        //    return View("CollectionViewer", collectionService.GetUserCollectionVMList(grantedId));
        //    //return RedirectToAction("CollectionViewer", new { collections = collectionService.GetUserCollectionList(getUserLocalId()) });
        //}

        [HttpGet]

        [Route("{id:int?}")]
        public ActionResult ShowUserCollectionsUWC(int? id)
        {
            if (id == -1)
                id = getUserLocalId();
            int grantedId = (int)(id ?? 0);
            return View("CollectionViewer", collectionService.GetUserCollectionList(grantedId));
            //return RedirectToAction("CollectionViewer", new { collections = collectionService.GetUserCollectionList(getUserLocalId()) });
        }

        [HttpGet]
        [Authorize]
        [Route("authusercollections")]
        public ActionResult ShowAuthorizedUserCollections()
        {
            return RedirectToAction("ShowUserCollectionsUWC", new { id = getUserLocalId()});
        }

        [HttpPost]
        [Route("{id:int}/uploadimage")]
        public async Task<IActionResult> SaveImageToServer([FromForm] IFormFile file)
        {
            string _apiKey = Environment.GetEnvironmentVariable("CloudinaryApiKey");//, EnvironmentVariableTarget.Machine);
            string _apiSecret = Environment.GetEnvironmentVariable("CloudinaryApiSecret");//, EnvironmentVariableTarget.Machine);
            string _cloud = Environment.GetEnvironmentVariable("CloudinaryCloud");//, EnvironmentVariableTarget.Machine);
            var myAccount = new Account { ApiKey = _apiKey, ApiSecret = _apiSecret, Cloud = _cloud };
            Cloudinary _cloudinary = new Cloudinary(myAccount);
            ImageUploadResult result = null;
            //foreach (var image in file)
            //{
                result = await _cloudinary.UploadAsync(new ImageUploadParams
                {
                    File = new FileDescription(file.FileName,
                        file.OpenReadStream()),
                    Tags = Tags
                }).ConfigureAwait(false);
            //}
            return Json(new { url = result.Url.AbsoluteUri});
        }   


        [Route("{id:int}/create")]
        [HttpPost]
        public ActionResult Create(CollectionViewModel collectionViewModel, int id)
        {
            if (ModelState.IsValid)
            {
                collectionViewModel.UserId = id;
                var createdCollection = collectionService.Create(collectionViewModel);
                //return View("CollectionViewer", collectionService.GetUserCollectionList(id));
                return RedirectToAction("ShowUserCollectionsUWC", new { id = id });
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        [Route("{id:int}/edit")]
        public ActionResult Edit(CollectionViewModel collectionViewModel)
        {
            if (ModelState.IsValid)
            {
                collectionService.Update(collectionViewModel);
                return RedirectToAction("Index");
            }
            return View(collectionViewModel);
        }

        [Route("{id:int}/delete/{collectionId:int}")]
        public ActionResult DeleteConfirmed(int id, int collectionId)
        {
            collectionService.Delete(collectionId);
            //return RedirectToAction("Index");
            return RedirectToAction("ShowUserCollectionsUWC", new { id = id });
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}
        //public ActionResult Delete()
        //{
        //    return View();
        //}

        public ActionResult Edit(int id)
        {
            //return RedirectToAction("Edit", roomService.GetRoom(id));
            return View(collectionService.GetCollection(id));
        }



        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    Room room = db.GetRoom(id);
        //    return View(room);
        //}
        //[HttpPost, ActionName("Delete")]


        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}
