using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleMvc.Models;

namespace SampleMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            List<IndexModel> newList = new List<IndexModel>();

            IndexModel newindexModel = new IndexModel
            {
                ID = 1,
                Description = "firstItem",
                Comments = "This is the first instance of the model"
            };


            IndexModel newindexModel2 = new IndexModel
            {
                ID = 2,
                Description = "secondItem",
                Comments = "This is the second instance of the model"
            };
            newList.Add(newindexModel);
            newList.Add(newindexModel2);
            return View(newList);
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();

        }


    }
}