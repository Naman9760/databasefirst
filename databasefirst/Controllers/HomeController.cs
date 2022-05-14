using databasefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace databasefirst.Controllers
{
    public class HomeController : Controller
    {
        Emp1Entities Db = new Emp1Entities();

        // GET: Home
        public ActionResult Index()
        {
            var data = Db.Employes.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employe emp)
        {
            Db.Employes.Add(emp);
            Db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}