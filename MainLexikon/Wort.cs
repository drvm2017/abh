using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLexikon
{
  public class Wort:IEquatable<Wort>
  {
    private String wort;

    public Wort(String wort)
    {
      this.wort = wort;
    }

    public override string ToString()
    {
      return "Wort: " + wort;
    }
    public override bool Equals(object obj)
    {
      if (obj == null) return false;
      Wort objAsWort = obj as Wort;
      if (objAsWort == null) return false;
      else return Equals(objAsWort);
    }
    public override int GetHashCode()
    {
      return (new Random()).Next(0, 2 ^ 32-1);
    }
    public bool Equals(Wort other)
    {
      if (other == null) return false;
      return this.wort == other.wort;
    }
  }
}
