using FirstClounProj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index() {
            return View();
        }
        public ViewResult About()
        {
            ViewBag.name1 = "Nice";

            dynamic data = new ExpandoObject();
            data.id = 5;
            data.name = "ViewBag";
            ViewBag.name2 = data;

            ViewBag.name3 = new BookModel() {bookAuthor="ViewBag" };

            return View();
        }
        public ViewResult Contact()
        {
            ViewData["name1"] = "ViewData";

            dynamic data = new ExpandoObject();
            data.id = 5;
            data.name = "ViewData";
            ViewData["name3"] = data;

            ViewData["name2"] = new BookModel() { bookAuthor= "ViewData" };

            return View();
        }
    }
}
