using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForscherTagDemo.Interfaces;

namespace ForscherTagDemo.Geometry
{
  public class Sphere : I3DForm
  {
    private double Radius { get; set; }
    public Sphere(double Radius)
    {
      this.Radius = Radius;
    }

    public double CalculateVolume()
    {
      return Math.Round((4 / 3) * Math.PI * Math.Pow(Radius, 3),2);
    }

    public double CalculateSurface()
    {
      return Math.Round(4 * Math.PI * Math.Pow(Radius, 2),2);
    }
  }
}
