using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.ComputerRepo;

namespace WebAppMVC.Controllers
{
    public class ComputerController : Controller
    {
        //GET: Computer
        public ActionResult Index()
        {
            var repo = new ComputerRepo1();
            return View(repo.GetAllComputer());
        }

        public ActionResult AddComp()
        {
            return View(new tblComputer());
        }

        [HttpPost]
        public ActionResult AddComp(tblComputer tbl)
        {
            var repo = new ComputerRepo1();
            repo.AddComputer(tbl);
            return RedirectToAction("Index");
        }
    }
}