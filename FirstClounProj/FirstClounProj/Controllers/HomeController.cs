using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstClounProj.Controllers
{
    public class HomeController: Controller
    {
        public string Index() {
            return "hi from home index method.";
        }
        public string About(int id)
        {
            return $"the id is {id}";
        }

    }
}
