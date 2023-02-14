using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class FirstExmapleController : Controller
    {
        // GET: FirstExmaple
        public string  HelloWord()
        {
            return "Wlecome To MVC";
        }

        public double Add(string v1,string v2)
        {
          var  num1 = double.Parse(v1);
            var nmu2= double.Parse(v2);
            return num1 + nmu2;

        }

        public ViewResult DisPlay()
        {
            var Comp = new Computer
            {
                CompId = 1,
                CompName = "Hp",
                CompPrice = 45000
            };
            return View(Comp);
        }
    }
}