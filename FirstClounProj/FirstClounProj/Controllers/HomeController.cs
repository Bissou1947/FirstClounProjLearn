using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index() {
            return View("~/OtherViewessource/OutView.cshtml");
            //return View("/OtherViewessource/OutView.cshtml");
            //return View("../../OtherViewessource/OutView");
            //var data = new {id=1,name="bassil"};
            //return View(data);
            //return View(data,"About");
            //return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        //public string About(int id)
        //{
        //    return $"the id is {id}";
        //}

    }
}
