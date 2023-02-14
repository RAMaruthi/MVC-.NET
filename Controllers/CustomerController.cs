using longIn.DataCompoent;
using longIn.DataRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace longIn.Controllers
{
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        //GET: Customer
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string pwd)
        {
            var com = new UserLogin();
            try
            {
                var cst = com.ValidateUser(email, pwd);
                Session["CustomerUser"] = cst;
                FormsAuthentication.SetAuthCookie(cst.cstEmail, false);
                FormsAuthentication.RedirectFromLoginPage(cst.cstEmail, false);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LoginError", ex.Message);
                return View();
            }
        }
        public ActionResult Add()
        {
            return View(new CustomerTbl());
        }
        [HttpPost]
        public ActionResult Add(CustomerTbl customer)
        {
            var repo = new UserLogin();
            repo.RegisterCustomer(customer);
            return RedirectToAction("Login");
        }

        
    }
}