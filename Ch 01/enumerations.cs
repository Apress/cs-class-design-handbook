// enumerations.cs
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
        Medal myMedal = Medal.Bronze;
        Console.WriteLine("My medal: " + myMedal.ToString());
    }
}
