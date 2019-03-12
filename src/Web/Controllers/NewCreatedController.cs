using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class NewCreatedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MyProject()
        {
            return Content("Welcome Home.");
        }


        public IActionResult MyProject1()
        {
            return View();
        }


        public IActionResult MyProject2()
        {
            return Json("file");
        }

        public IActionResult MyProject3()
        {
            return View();
        }

       

    }
}