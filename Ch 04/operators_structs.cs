// created on 12/24/2002 at 1:00 PM
using System;

public struct Fraction
{

  private int numerator;
  private int denominator;

  public int Numerator
  {
    get { return numerator; }
    set { numerator = value; }
  }

  public int Denominator
  {
    get { return denominator; }
    set { denominator = value; }
  }

  private static int lcd(int x, int y)
  {
    int r, t = x * y;

    while (true) 
    {
      r = x % y;
      if (r == 0) break;
      x = y; y = r;
    }

    return (t / y);
  }

  public static Fraction operator+(Fraction lh_fraction,
    Fraction rh_fraction)
  {
    Fraction result = new Fraction();
    result.Denominator = lcd(lh_fraction.Denominator,
      rh_fraction.Denominator);
    result.Numerator = lh_fraction.Numerator *
      (result.Denominator / lh_fraction.Denominator) + 
      rh_fraction.Numerator *
      (result.Denominator / rh_fraction.Denominator); 
    return result;
  }

  public static Fraction operator-(Fraction lh_fraction,
    Fraction rh_fraction)
  {
    Fraction result = new Fraction();
    result.Denominator = lcd(lh_fraction.Denominator,
      rh_fraction.Denominator);
    result.Numerator = lh_fraction.Numerator *
      (result.Denominator / lh_fraction.Denominator) - 
      rh_fraction.Numerator *
      (result.Denominator / rh_fraction.Denominator); 
    return result;
  }

  public override string ToString()
  { return (numerator.ToString() + "/" + denominator.ToString()); }
}

class FractionCalculator
{
  static void Main()
  {
    Fraction fraction1 = new Fraction();
    fraction1.Numerator = 2;
    fraction1.Denominator = 5;

    Fraction fraction2 = new Fraction();
    fraction2.Numerator = 1;
    fraction2.Denominator = 7;

    Console.WriteLine("Fraction 1 = " + fraction1.ToString());
    Console.WriteLine("Fraction 2 = " + fraction2.ToString());
    Console.WriteLine();

    Console.WriteLine("Fraction 1 + Fraction 2 = " + (fraction1 + fraction2).ToString());
    Console.WriteLine("Fraction 1 - Fraction 2 = " + (fraction1 - fraction2).ToString());
  }
}
