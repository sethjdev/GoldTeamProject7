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

namespace GoldTeamProject7.Models
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index(int ? page)
        {
            var products = from p in db.Products
                           where p.Availability == true
                           orderby p.UploadDate descending
                           select p;

          var skip = 12;
          var take = 12;
          var query = products.Skip(skip).Take(take);

          int pageSize = 12;
          int pageNumber = (page ?? 1);
         
          return View(products.ToPagedList(pageNumber, pageSize));

        }

        [Authorize(Users="seth.johnson0126@gmail.com")]
        public ActionResult AdminDashboard() 
        {
            var model = new AdminViewModel
            {
                productList = (from p in db.Products
                               select p).ToList(),
                userList = (from u in db.Users
                                select u).ToList(),
                messageList = (from m in db.Messages
                                select m).ToList()
            };
            

            return View(model);
        }
    }
}