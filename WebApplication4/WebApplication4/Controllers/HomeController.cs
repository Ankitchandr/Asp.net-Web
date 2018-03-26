using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication4.AuthData;

namespace WebApplication4.Controllers
{
    [AuthData.ManageController]
    public class HomeController : Controller
    {

        public ActionResult GiveMeSomeText()
        {
            return Content("<h1> Hii.. I am staing In Banglore<h1>");

        }

        public ActionResult Index()
        {
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello Ankit Chandra..";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = " This is Ankit MVC page";

            return View();
        }
     
    }
}