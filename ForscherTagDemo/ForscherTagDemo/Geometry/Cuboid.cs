using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForscherTagDemo.Interfaces;

namespace ForscherTagDemo.Geometry
{
  public class Cuboid : I3DForm
  {
    private double Length { get; set; }
    private double Width { get; set; }
    private double Height { get; set; }

    public Cuboid(double Length, double Width, double Height)
    {
      this.Length = Length;
      this.Height = Height;
      this.Width = Width;
    }

    public double CalculateVolume()
    {
      return Math.Round(Length * Height * Width, 2);
    }

    public double CalculateSurface()
    {
      return Math.Round(2 * Length * Width + 2 * Width * Height + 2 * Length * Height, 2);
    }
  }
}
