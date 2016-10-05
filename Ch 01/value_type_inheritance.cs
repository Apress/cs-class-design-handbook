// value_type_inheritance.cs
using System;

struct Money : IComparable
{
    // private fields
    private int centsAmount;
    private const string currencySymbol = "$";

    // public constructors
    public Money(int dollars, int cents)
    {
        centsAmount = (dollars * 100) + cents;
    }

    public Money(double amount)
    {
        centsAmount = (int)((amount * 100.0) + 0.5);
    }

    // compare with another Money
    public int CompareTo(object other)
    {
        Money m2 = (Money)other;
        if (centsAmount < m2.centsAmount)
            return -1;
        else if (centsAmount == m2.centsAmount)
            return 0;
        else
            return 1;
    }

    // return value as a string
    public override string ToString()
    {
        return currencySymbol + 
            (centsAmount / 100.0).ToString();
    }
}
class MyClass
{
    [STAThread]
    static void Main(string[] args)
    {
        // create an array of 5 items
        Money[] salaries = new Money[5];
        salaries[0] = new Money(9.50);
        salaries[1] = new Money(4.80);
        salaries[2] = new Money(8.70);
        salaries[3] = salaries[2];
        salaries[4] = new Money(6.30);

        // display unsorted array
        Console.WriteLine("Unsorted array:");
        foreach (Money salary in salaries)
        {
            Console.WriteLine("{0}", salary);
        }

        // sort the array
        Array.Sort(salaries);

        // display sorted array
       Console.WriteLine(" ");
        Console.WriteLine("Sorted array:");
        foreach (Money salary in salaries)
        {
            Console.WriteLine("{0}", salary);
        }
    }
}

// created on 11/26/2002 at 6:02 PM
