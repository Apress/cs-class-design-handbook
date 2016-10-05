// created on 11/26/2002 at 4:31 PM
// primitive_types.cs
using System;                // for Console class
class MyClass
{
    [STAThread]
    static void Main(string[] args)
    {
        int i = 100;    // use a primitive C# type
        Int32 j = i;    // use the equivalent .NET framework type
        Console.WriteLine("int:     {0}", typeof(int).FullName);
        Console.WriteLine("Int32:   {0}", typeof(Int32).FullName);

        // ask user for numerator and denominator
        Console.Write("\nEnter a double: ");

        string input = Console.ReadLine();
        double num = Double.Parse(input);

        Console.Write("Enter another double: ");
        input = Console.ReadLine();
        double denom = Double.Parse(input);

        // calculate quotient and display it
        double res = num / denom;
        if (Double.IsNaN(res)) 
            Console.WriteLine("Not a Number.");
        else if (Double.IsPositiveInfinity(res)) 
            Console.WriteLine("Positive infinity.");
        else if (Double.IsNegativeInfinity(res)) 
            Console.WriteLine("Negative infinity.");
        else 
            Console.WriteLine("Result is {0}.", res);
    }
}
