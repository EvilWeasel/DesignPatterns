using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  public class MyHouse
  {
    public bool HasEntrance = false;
    public int NumberOfDoors = 4;
    public bool HasWindows = false;
    public bool HasRoof = false;
    public bool HasBackyard = false;
    public int BackyardSizeSqrMeters = 0;

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      PropertyInfo[] properties = this.GetType().GetProperties();
      foreach (PropertyInfo property in properties)
      {
        sb.Append(property.Name + ": " + property.GetValue(this).ToString() + "\n");
        Console.WriteLine(property.Name + ": " + property.GetValue(this).ToString());
      }
      return sb.ToString();
    }
  }
  public class MyBuilder
  {
    public MyHouse House;
    public MyBuilder()
    {
      this.Reset();
    }
    public MyBuilder Reset()
    {
      House = new MyHouse();
      return this;
    }
    public MyBuilder AddEntrance()
    {
      House.HasEntrance = true;
      return this;
    }
    public MyBuilder AddDoors(int numberOfDoors)
    {
      House.NumberOfDoors = numberOfDoors;
      return this;
    }
    public MyBuilder SealHouse()
    {
      House.HasWindows = true;
      House.HasRoof = true;
      return this;
    }
    public MyBuilder SetBackyardAndSize(int backyardSizeSqrMeters)
    {
      House.HasBackyard = true;
      House.BackyardSizeSqrMeters = backyardSizeSqrMeters;
      return this;
    }
    public MyHouse Build()
    {
      return House;
    }

  }
}
