using ForscherTagDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForscherTagDemo.Geometry
{
  public class PaintableContainer
  {
    private List<IPaintable> paintables;
    public PaintableContainer()
    {
      paintables = new();
    }

    public void Add(IPaintable Item)
    {
      paintables.Add(Item);
    }
    public void Clear()
    {
      paintables.Clear();
    }
    public int Length()
    {
      return paintables.Count;
    }

    public double Calculate()
    {
      double sum = .0;
      foreach (var Item in paintables)
        sum += Item.CalculateSurface();
      return sum;
    }
  }
}
