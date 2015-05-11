using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoldTeamProject7.Models;
using PagedList;

namespace GoldTeamProject7.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index(int ? page)
        {
            var products = from p in db.Products
                           where p.Availability == true
                           orderby p.Title
                           select p;

          var skip = 4;
          var take = 4;
          var query = products.Skip(skip).Take(take);

          int pageSize = 5;
           int pageNumber = (page ?? 1);
         
          return View(products.ToPagedList(1, pageSize));

         
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}