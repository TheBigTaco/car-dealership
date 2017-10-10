using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;
using System;

namespace CarDealership.Controllers
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
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
    [HttpPost("/car/create")]
    public ActionResult CreateCar()
    {
      try{
        Car newCar = new Car(Request.Form["make-model"], Request.Form["new-price"],Request.Form["new-miles"]);
        newCar.Save(newCar);
        return View(newCar);
      } catch(Exception) {
        return View(null);
      }
    }
    [HttpPost("car/list/clear")]
    public ActionResult CarListClear()
    {
      Car.ClearAll();
      return View();
    }
  }
}
