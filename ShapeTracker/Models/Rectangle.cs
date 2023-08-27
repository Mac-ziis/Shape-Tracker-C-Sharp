using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; set; }

    private static List<Rectangle> _instances = new List<Rectangle> { };

    public Rectangle(int length1, int length2)
    {
      _side1 = length1;
      Side2 = length2;
      _instances.Add(this);
    }

    public string CheckType()
    {
      if ((_side1 == Side2))
      {
        return "Not a rectangle, is a square";
      }
      else 
      {
        return "This is a rectangle!";
      }
    }

     public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Rectangle> GetAll()
    {
      return _instances;
    }
  }
}