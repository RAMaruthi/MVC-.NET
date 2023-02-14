using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.CurdOpertion;

namespace WebAppMVC.Controllers
{
    public class CarInfoController : Controller
    {
        // GET: CarInfo
        public ActionResult Index()
        {
            var repo = new CarInfoRepo();
            var cars = repo.GetAllCars();
            return View(cars);
        }


        [HttpPost]
        public ActionResult Edit(CarInfo updateData)
        {
            var repo = new CarInfoRepo();
            repo.UpdateCar(updateData);
            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Message = "Car ID Is Not Set ,Please Visit Index Page!!!!";
                return View();
            }

            var selectedId = int.Parse(id);
            var repo = new CarInfoRepo();
            var model = repo.FindCar(selectedId);
            if (model == null)
            {
                ViewBag.Message = "Car Infromation Is Not Available With Us!!!!";
                return View();
            }

            return View(model);
        }

        public ActionResult AddCar()

        {
            return View(new CarInfo());
        }
        [HttpPost]
        public ActionResult AddCar(CarInfo carInfo)

        {
            var repo = new CarInfoRepo();
            repo.AddNewCar(carInfo);
            return RedirectToAction("Index");
        }

     
        public ActionResult DeleteCar(string id)
        {
            var carId = int.Parse(id);
            var repo = new CarInfoRepo();
            repo.DeleteCar(carId);
            return RedirectToAction("Index");
        }

       
    }
}