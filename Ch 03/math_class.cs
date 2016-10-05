// created on 11/28/2002 at 12:13 PM
using System;
public class MathsClass
{
  private int Multiply(int a, int b)
  {
  	Console.WriteLine("multiply called");
    return (a * b);
  }
  public static void Main()
  {
  	int a=10;
  	int b=20;
  	MathsClass mc = new MathsClass();
  	
  Console.WriteLine("Product ", mc.Multiply(a,b));
  }
}
