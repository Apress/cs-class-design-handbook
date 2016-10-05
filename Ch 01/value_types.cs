// created on 11/26/2002 at 5:55 PM
// value_types.cs
using System;

struct Money
{
    // private instance field
    private int centsAmount;

    // private class field
    private const string currencySymbol = "$";

    // public constructor
    public Money(int dollars, int cents)
    {
        centsAmount = (dollars * 100) + cents;
    }

    // another public constructor
    public Money(double amount)
    {
        centsAmount = (int)((amount * 100.0) + 0.5);
    }
}

class MyClass
{
    [STAThread]
    static void Main(string[] args)
    {
        // entry point for the console application
//        Money freebie;
        Money salary = new Money(20000, 0);
        Money carPrice = new Money(34999.95);
    }
}
