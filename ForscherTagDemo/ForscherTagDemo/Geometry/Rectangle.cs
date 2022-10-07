using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForscherTagDemo.Interfaces;

namespace ForscherTagDemo.Geometry
{
  public class Rectangle : I2DForm
  {
    private double Height { get; set; }
    private double Width { get; set; }

    public Rectangle(double Height, double Width)
    {
      this.Height = Height;
      this.Width = Width;
    }

    public double CalculateSurface()
    {
      return Height * Width;
    }

    public double CalculateCircumfence()
    {
      return 2 * Height + 2 * Width;
    }
  }
}
