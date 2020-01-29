using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLexikon
{
  public class Wort : IEquatable<Wort>
  {
    private String wortlaut;
    private int anzahlBelege = 1;
    public Boolean zweifelhaft;

    public Wort(String wortlaut)
    {
      this.wortlaut = wortlaut;
    }
    public String getWortlaut()
    {
      return this.wortlaut;
    }
    public void erhöheAnzahlBelege()
    {
      this.anzahlBelege++;
    }
    public int getAnzahlBelege()
    {
      return this.anzahlBelege;
    }
    public override string ToString()
    {
      return "Wort: " + wortlaut;
    }
    public override bool Equals(object obj)
    {
      if (obj == null) return false;
      Wort objAsWort = obj as Wort;
      if (objAsWort == null) return false;
      else return Equals(objAsWort);
    }
    public bool Equals(Wort other)
    {
      if (other == null) return false;
      return this.wortlaut == other.getWortlaut();
    }


  }
}
