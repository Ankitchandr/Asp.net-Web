using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public ActionResult  AddOrEdit(int Id=0)
        {
            Emp empModel = new Emp();
            
            return View(empModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(Emp empModel)
        {
            using (MyDataBaseEntities dbmodel = new MyDataBaseEntities())
            {
                dbmodel.Emps.Add(empModel);
                dbmodel.SaveChanges();
                
               
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Regestration Successfully";
            return View(" AddOrEdit",new Emp());
        }
    }

   
}