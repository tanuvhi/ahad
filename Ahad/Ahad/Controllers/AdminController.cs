using Ahad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ahad.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        EFDbContext contex =new EFDbContext();
        public AdminController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult UnitList( )
        {

            List<Unit> model; 
            model = contex.Units.ToList();
            return View(model);
        }
        public ViewResult UnitCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnitCreate(Unit model)
        {
       
        if(ModelState.IsValid)
        {
            contex.Units.Add(model);
            contex.SaveChanges();
        }
            return RedirectToAction("UnitList");
        }
	}
}