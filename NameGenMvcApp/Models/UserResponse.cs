using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NameGenMvcApp.Controllers;
using System.ComponentModel.DataAnnotations;

namespace NameGenMvcApp.Models
{
    public class UserResponse
    {
        public String Race { get; set; }
        public String GeneratedName { get; set; }
        public String Sex { get; set; }
    }

   
}