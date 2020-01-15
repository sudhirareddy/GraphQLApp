using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLApp.Controllers
{
    public class HomeController : Controller
    { //GET : Home
        public IActionResult Index()
        {
            return View();
        }
    }
}