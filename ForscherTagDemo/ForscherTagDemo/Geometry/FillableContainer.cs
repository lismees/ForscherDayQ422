using ForscherTagDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForscherTagDemo.Geometry
{
  public class FillableContainer
  {
    private List<IFillable> fillables;
    public FillableContainer()
    {
      fillables = new List<IFillable>();
    }
    public void Add(IFillable Item)
    {
      fillables.Add(Item);
    }
    public void Clear()
    {
      fillables.Clear();
    }
    public int Length()
    {
      return fillables.Count;
    }

    public double Calculate()
    {
      double sum = .0;
      foreach (var Item in fillables)
        sum += Item.CalculateVolume();
      return sum;
    }
  }
}
