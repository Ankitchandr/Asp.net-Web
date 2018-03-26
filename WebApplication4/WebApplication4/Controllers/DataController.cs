using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication4.Controllers
{
    public class DataController
    {
        [OutputCache(Duration = 10)]
        public string Index()
        {
            return DateTime.Now.ToString("T");
        }
    }
}