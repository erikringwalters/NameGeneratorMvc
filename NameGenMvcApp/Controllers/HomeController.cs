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
            var model = new UserResponse();
            var nameGenerator = new NameGenerator();
            model.GeneratedName = nameGenerator.getName(0, model.Sex, model.Race);
            return View(model);
        }

        [HttpPost]
        public ViewResult CharacterInfoForm(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                //userResponse.GeneratedName = Name is generated for " + userResponse.Race + " " + userResponse.Sex;
                Random randSize = new Random();
                var nameGenerator = new NameGenerator();
                userResponse.GeneratedName = nameGenerator.getName(randSize.Next(1, 10), userResponse.Sex, userResponse.Race );
                return View(userResponse);
            }
            else
            {
                return View();
            }
        }
    };
}