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
    Console.Write("\nEnter a medal:");
    string input = Console.ReadLine();
    Medal myMedal= (Medal) Enum.Parse(typeof(Medal), input, true);
    Console.WriteLine("You entered: " + myMedal.ToString());

   
   }
}
