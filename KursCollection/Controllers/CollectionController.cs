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

        public AppUser getLocalUser()
        {
            var currentUserEmail = HttpContext.User.Identity.Name;
            AppUser user = _context.AppUsers.FirstOrDefault(u => u.UserEmail == currentUserEmail);
            return user;//.UserId;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult ShowAllCollections()
        {
            return View("AllCollectionViewer", collectionService.GetCollectionVMList());
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
                id = getLocalUser().UserId;
            int grantedId = (int)(id ?? 0);
            
            AppUser user = getLocalUser();
            
            if(user == null)
            {
                ViewBag.OwnerRights = false;
            }
            else if(user.UserId != id)
            {
                if (!user.IsAdmin)
                    ViewBag.OwnerRights = false;
                else ViewBag.OwnerRights = true;
            }
            else    
                ViewBag.OwnerRights = true;
            return View("CollectionViewer", collectionService.GetUserCollectionList(grantedId));
            //return RedirectToAction("CollectionViewer", new { collections = collectionService.GetUserCollectionList(getUserLocalId()) });
        }

        [HttpGet]
        [Authorize]
        [Route("authusercollections")]
        public ActionResult ShowAuthorizedUserCollections()
        {
            return RedirectToAction("ShowUserCollectionsUWC", new { id = getLocalUser().UserId});
        }

        [HttpPost]
        [Route("{id:int}/uploadimage")]
        public async Task<IActionResult> SaveImageToServer([FromForm] IFormFile file)
        {
            string _apiKey = Environment.GetEnvironmentVariable("CloudinaryApiKey");//, EnvironmentVariableTarget.Machine); //https://stackoverflow.com/questions/185208/how-do-i-get-and-set-environment-variables-in-c
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

        //[HttpPost]
        [HttpGet]
        [Route("{id:int}/create1")]
        public ActionResult CreateCollection(int id)
        {
            var tmp = _context.Themes.ToList();
            ViewBag.Themes = new List<Theme>(tmp);
            return View(collectionService.GetUserCollectionList(id));
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

        [HttpGet]
        [Route("{UserId:int}/edit1/{id:int}")]
        public ActionResult EditCollection(int id)
        {
            var tmp = _context.Themes.ToList();
            ViewBag.Themes = new List<Theme>(tmp);
            return View(collectionService.GetCollection(id));// .GetUserCollectionList(id));
        }

        [HttpPost]
        [Route("{id:int}/edit")]
        public ActionResult Edit(CollectionViewModel collectionViewModel)
        {
            if (ModelState.IsValid)
            {
                collectionService.Update(collectionViewModel);
                return RedirectToAction("ShowUserCollectionsUWC", new { id = collectionViewModel.UserId});
            }
            return RedirectToAction("ShowUserCollectionsUWC", new { id = collectionViewModel.UserId });
        }


        [Route("{id:int}/delete/{collectionId:int}")]
        public ActionResult DeleteConfirmed(int id, int collectionId)
        {
            collectionService.Delete(collectionId);
            //return RedirectToAction("Index");
            return RedirectToAction("ShowUserCollectionsUWC", new { id = id });
        }

    }
}
