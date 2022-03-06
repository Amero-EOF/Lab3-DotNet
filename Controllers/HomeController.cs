using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualStudio.Web.CodeGeneration;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [HttpPost]
        public ActionResult Razor()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Count()
        {
            int amount;
            try
            {
                amount = Int32.Parse(Request.Form["Bottles"]);
                ViewData["count"] = amount;
                if ( amount  < 50)
                {
                    return View("Razor");
                }
            } catch { return View("Razor"); }
            
            return View();
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
            return View();
        }


        [HttpPost]
        public ActionResult displayPerson()
        {
            Person model = new Person();
            foreach (KeyValuePair<string,StringValues> i in Request.Form)
            {
                if (i.Value.Equals(""))
                {
                    return View("CreatePerson");
                }
            }
            
            model.FirstName = Request.Form["firstName"];
            model.LastName = Request.Form["lastName"];
            try { model.Age = Int32.Parse(Request.Form["age"]); } catch { }
            model.EmailAddress = Request.Form["emailAddr"];
            model.DateOfBirth = DateTime.Parse(Request.Form["dateOfBirth"]);
            model.Description = Request.Form["description"];
            return View(model);
        }


    }
}
