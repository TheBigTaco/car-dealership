using System.Collections.Generic;

namespace Car.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<string> _instances = new List<string> {};

    public Car (string MakeModel, int Price, int Miles)
    {
      _makeModel = MakeModel;
      _price = Price;
      _miles = Miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel (string newMakeModel)
    {
      _makeModel = newMakeModel;
    }


    public string GetPrice()
    {
      return _price;
    }
    public void SetPrice (string newPrice)
    {
      _price = newPrice;
    }


    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles (string newMiles)
    {
      _miles = newMiles;
    }

    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_makeModel, _price, _miles);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
