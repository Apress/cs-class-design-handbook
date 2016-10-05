// enumerations2.cs
using System;
 enum Medal : short
    {
        Gold,
        Silver,
        Bronze
    }

class MyClass
{
   

    [STAThread]
    static void Main(string[] args)
    {
       Medal[] medals = (Medal[])Enum.GetValues(typeof(Medal));
      foreach (Medal m in medals)
      {
         Console.WriteLine("{0:D}\t{1:G}", m,m);
      }
   }
}
