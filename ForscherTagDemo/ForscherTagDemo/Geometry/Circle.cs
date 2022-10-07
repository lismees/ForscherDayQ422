using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForscherTagDemo.Interfaces;

namespace ForscherTagDemo.Geometry
{
  public class Circle : I2DForm
  {
    private double Radius;

    public Circle(double Radius)
    {
      this.Radius = Radius;
    }

    public double CalculateSurface()
    {
      return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }

    public double CalculateCircumfence()
    {
      return Math.Round(2 * Math.PI*Radius, 2);
    }
  }
}
