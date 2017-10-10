using Microsoft.AspNetCore.Mvc;
using Car.Models;
using System.Collections.Generic;

namespace Car.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View();
      }
      [Route("/car/list")]
      public ActionResult CarsList()
      {
        List<string> allCars = Car.GetAll();
        return View(allCars);
      }
      [HttpPost("/car/create")]
      public ActionResult CreateCar()
      {
        Car newCar = new Car(Request.Form["make-model"], Request.Form["new-price"],Request.Form["new-miles"]);

        newCar.Save();
        return View(newCar);
      }
      [HttpPost("/car/list/clear")]
      public ActionResult CarListClear()
      {
        Car.ClearAll();
        return View();
      }
    }
}
