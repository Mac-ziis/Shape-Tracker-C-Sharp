using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {
    public void Dispose()
    {
      Rectangle.ClearAll();
    }

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(4, 5);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 5);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }
    
    [TestMethod]
    public void ClearAll_DeletesAllRetangleInList_Void()
    {
      // Arrange
      Rectangle rec1 = new Rectangle(2, 4);
      Rectangle rec2 = new Rectangle(5, 10);
      List<Rectangle> expected = new List<Rectangle> { };
      Rectangle.ClearAll();
      // Assert
      CollectionAssert.AreEqual(expected, Rectangle.GetAll());
    }

    [TestMethod]

    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(2, 4);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]

    public void CheckType_DrerminesWhenNotARectangle_String()
    {
      Rectangle notARectangle = new Rectangle(5, 5);
      string recType = notARectangle.CheckType();
      Assert.AreEqual("Not a rectangle, is a square", recType);
    }

    [TestMethod]
    public void GetAll_ReturnsAllRectangleInstances_List()
    {
      Rectangle rect1 = new Rectangle(5, 6);
      Rectangle rect2 = new Rectangle(5, 5);
      List<Rectangle> expected = new List<Rectangle> { rect1, rect2 };
      List<Rectangle> actualResult = Rectangle.GetAll();
      // CollectionAssert.AreEqual(expected, actualResult);
     }
  }
}


