using EmployeeLib;
using EmployeeLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.ViewModel;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly EmployeeDataComponent repo = new EmployeeDataComponent();
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult AllEmp()
        {
            var rec = repo.GetAllEmployess();
            return PartialView(rec);
        }

        public ActionResult Add()
        {
            ViewBag.DeptList = repo.GetAllDepts();
            return PartialView(new myViewmodl());
        }
        [HttpPost]
        public ActionResult Add(myViewmodl emp)
        {
            ViewBag.DeptList = repo.GetAllDepts();
            if (ModelState.IsValid)
            {
                var e = new tblEmp
                {
                    empName = emp.empName,
                    empAdd = emp.empAdd,
                    empSalary = emp.empSalary,
                    deptId = emp.deptId
                };
                repo.AddNewEmployee(e);
                return RedirectToAction("Index");

            }
            else
            {
                return View(emp);
            }
        }

        public ActionResult Edit1(string id)
        {
            ViewBag.depts = repo.GetAllDepts();
            var selectedId = int.Parse(id);
            var foundemp = repo.FindEmp(selectedId);
            return PartialView(foundemp);
        }
        [HttpPost]
        public ActionResult Edit1(tblEmp emp)
        {

            
            repo.UpdateEmployee(emp);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var Id = int.Parse(id);
            repo.DeleteEmployee(Id);
            return RedirectToAction("AllEmp");
        }


    }
}