using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForscherTagDemo.Tests.Geometry
{
  [TestClass]
  public class I3DFormTest
  {
    [TestMethod]
    public void TestSphereCalculations()
    {
      Sphere sphere = new Sphere(10);
      Assert.AreEqual(3141.59, sphere.CalculateVolume());
      Assert.AreEqual(1256.64, sphere.CalculateSurface());
      Assert.AreEqual(3141.59, (sphere as I3DForm).CalculateVolume());
      Assert.AreEqual(1256.64, (sphere as I3DForm).CalculateSurface());
    }
    [TestMethod]
    public void TestCubeCalculations()
    {
      Cube cube = new Cube(10);
      Assert.AreEqual(1000, cube.CalculateVolume());
      Assert.AreEqual(600, cube.CalculateSurface());
      Assert.AreEqual(1000, (cube as I3DForm).CalculateVolume());
      Assert.AreEqual(600, (cube as I3DForm).CalculateSurface());
    }

    [TestMethod]
    public void TestRectangleCalculations()
    {
      Cuboid cuboid = new Cuboid(10, 10, 10);
      Assert.AreEqual(1000, cuboid.CalculateVolume());
      Assert.AreEqual(600, cuboid.CalculateSurface());
      Assert.AreEqual(1000, (cuboid as I3DForm).CalculateVolume());
      Assert.AreEqual(600, (cuboid as I3DForm).CalculateSurface());
    }
  }
}
