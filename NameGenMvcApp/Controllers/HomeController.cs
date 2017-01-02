using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NameGenMvcApp.Controllers;
using NameGenMvcApp.Models;

namespace NameGenMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult CharacterInfoForm()
        {
            return View(new UserResponse());
        }

        [HttpPost]
        public ViewResult CharacterInfoForm(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                userResponse.GeneratedName = "Name is generated for " + userResponse.Race + " " + userResponse.Sex;
                return View(userResponse);
            }
            else
            {
                return View();
            }
        }
    };
}