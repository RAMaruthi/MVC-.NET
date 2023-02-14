using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC.Controllers
{
    public class CaclController : Controller
    {
        // GET: Cacl
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string FirstValue, string SecondValue, string Operand)
        {
            var v1 = double.Parse(FirstValue);
            var v2 = double.Parse(SecondValue);
            string Message = string.Empty;
            switch (Operand)
            {
                case "Add":
                    Message= (v1 + v2).ToString();
                    break;
                case "Sub":
                    Message += (v1 - v2).ToString();
                    break;
                case "Mul":
                    Message += (v1 * v2).ToString();
                    break;
                case "Div":
                     Message += (v1 / v2).ToString();
                    break;
                default:
                    break;
            }
            ViewBag.Message = $"The Result Is : {Message}";
            return View();
        }
    }
}