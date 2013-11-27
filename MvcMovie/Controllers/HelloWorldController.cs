using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int id = 1) 
        {
            ViewBag.ID = id;
            ViewBag.Message = name;
            return View();
            //return HttpUtility.HtmlEncode("Hello " + name + ", num time is : " + id);
        }
	}
}