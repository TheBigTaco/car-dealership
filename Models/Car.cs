using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    private static List<Car> _instances = new List<Car> {};

    public Car (string MakeModel, string Price, string Miles)
    {
      Regex regex = new Regex(@"\d+");
      Match resultMiles = regex.Match(Miles);
      Match resultPrice = regex.Match(Price);
      if (resultMiles.Success && resultPrice.Success) {
        _price = int.Parse(Price);
        _miles = int.Parse(Miles);
        _makeModel = MakeModel;
      } else {
        throw new Exception("Please enter in the correct format");
      }
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel (string newMakeModel)
    {
      _makeModel = newMakeModel;
    }


    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice (int newPrice)
    {
      _price = newPrice;
    }


    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles (int newMiles)
    {
      _miles = newMiles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save(Car newCar)
    {
      _instances.Add(newCar);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
