using System;

public class MyClass
{
    public static void Main()
    {
        Console.WriteLine("Select an option: ");
        Console.WriteLine("  1  C to F");
        Console.WriteLine("  2  F to C");
        Console.WriteLine("  3  Miles to Km");
        Console.WriteLine("  4  Km to Miles");
        Console.Write("=>");

        string input = Console.ReadLine();
        int opt = Int32.Parse(input);

        Console.Write("Value to convert: ");
        input = Console.ReadLine();
        double value = Double.Parse(input);

        double result;
        switch (opt)
        {
            case 1:
                result= TempConverter.CelsiusToFahr(value);
                break;
            case 2:
                result= TempConverter.FahrToCelsius(value);
                break;
            case 3:
                result= DistanceConverter.MileToKm(value);
                break;
            case 4:
                result= DistanceConverter.KmToMile(value);
                break;
            default:
                Console.WriteLine("Invalid option");
                return;
        }

        Console.WriteLine("Result: {0}", Math.Round(result, 2));
    }
}
