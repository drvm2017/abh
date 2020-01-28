using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLexikon
{
  public class Program
  {
    public static void Main(string[] args)
    {
      String[] worte;
      Wort wort;
      Lexikon lexikon = new Lexikon();
      String eingabe=Console.ReadLine();
      worte = eingabe.Split(new String[] { ",", ".", ";", ":", " " }, StringSplitOptions.RemoveEmptyEntries);

      for (int i = 0; i < worte.Length; i++)
      {
        wort = new Wort(worte[i]);
        if (lexikon.Contains(wort))
        {

        }
        else
        {
          lexikon.Add(wort);
        }
      }
      Console.ReadLine();
    }
  }
}
