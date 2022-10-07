using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForscherTagDemo.Tests.Geometry
{
  [TestClass]
  public class I2DFormTest
  {
    [TestMethod]
    public void TestCircleCalculations()
    {
      Circle circle = new Circle(10);
      Assert.AreEqual(62.83, circle.CalculateCircumfence());
      Assert.AreEqual(314.16, circle.CalculateSurface());
      Assert.AreEqual(62.83, (circle as I2DForm).CalculateCircumfence());
      Assert.AreEqual(314.16, (circle as I2DForm).CalculateSurface());
    }
    [TestMethod]
    public void TestSquareCalculations()
    {
      Square square = new Square(10);
      Assert.AreEqual(40, square.CalculateCircumfence());
      Assert.AreEqual(100, square.CalculateSurface());
      Assert.AreEqual(40, (square as I2DForm).CalculateCircumfence());
      Assert.AreEqual(100, (square as I2DForm).CalculateSurface());
    }

    [TestMethod]
    public void TestRectangleCalculations()
    {
      Rectangle rectangle = new Rectangle(10, 10);
      Assert.AreEqual(40, rectangle.CalculateCircumfence());
      Assert.AreEqual(100, rectangle.CalculateSurface());
      Assert.AreEqual(40, (rectangle as I2DForm).CalculateCircumfence());
      Assert.AreEqual(100, (rectangle as I2DForm).CalculateSurface());
    }
  }
}
