using KursCollection.Data;
using KursCollection.Models;
using KursCollection.Services.Interface;
using KursCollection.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace KursCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        ICollectionService collectionService;
        IItemService itemService;

        public HomeController(ICollectionService collectionService, IItemService itemService, ApplicationDbContext db, ILogger<HomeController> logger)
        {
            this.collectionService = collectionService;
            this.itemService = itemService;
            _context = db;
            _logger = logger;
        }

        public string GetColNameById(int id)
        {
            //var currentUserEmail = HttpContext.User.Identity.Name;
            var collection = _context.Collections.FirstOrDefault(c => c.CollectionId == id);
            return collection.CollectionName;
        }

        //public ActionResult ChangeTheme()
        //{
        //    if (Request.Cookies["theme"].Value == null)
        //    {
        //        Response.Cookies["theme"].Value = "dark";
        //    }
        //    else
        //    {
        //        if (Request.Cookies["theme"].Value == "dark")
        //        {
        //            Response.Cookies["theme"].Value = "light";
        //        }
        //        else if (Request.Cookies["theme"].Value == "light")
        //        {
        //            Response.Cookies["theme"].Value = "dark";
        //        }
        //    }

        //    Response.Redirect(Request.RawUrl);
        //    return RedirectToAction("Index");
        //}
        

        public IActionResult Index()
        {
            var list = itemService.GetiIemLast5VMList();
            var list2 = new List<ItemViewModel>();
            foreach (var elem in list)
            {
                var tmp = GetColNameById(elem.CollectionId);
                elem.CollectionName = tmp;
                list2.Add(elem);
            }
            ViewBag.LastItems = list2;
            return View(collectionService.GetCollectionTop3VMList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
