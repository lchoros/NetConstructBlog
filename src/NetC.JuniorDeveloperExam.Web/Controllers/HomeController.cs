using NetC.JuniorDeveloperExam.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string path = Server.MapPath("~/App_Data/Blog-Posts.json");
            StreamReader r = new StreamReader(path);
            string jsonString = r.ReadToEnd();
            Root blogPosts = JsonConvert.DeserializeObject<Root>(jsonString);
            return View(blogPosts.BlogPosts);
        }
    }
}