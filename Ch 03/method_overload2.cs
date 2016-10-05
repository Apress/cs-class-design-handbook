// created on 12/2/2002 at 7:40 PM

using System;
public class method_overload2{

private double CalculateCost(double orderCost)
{
  // Calculate total cost
  Console.WriteLine(" ");
  Console.WriteLine("CalculateCost(double)");
  return (this.CalculateCost(orderCost, 0, 0));
	
}

private double CalculateCost(double orderCost, double deliveryFee)
{
  // Calculate total cost
  Console.WriteLine(" ");
  Console.WriteLine("CalculateCost(double, double)");
  return (this.CalculateCost(orderCost, deliveryFee, 0));
}

private double CalculateCost(double orderCost, double deliveryFee, double handlingFee)
{
  // Calculate total cost
  Console.WriteLine(" ");
  Console.WriteLine("CalculateCost(double, double, double)");
  return (orderCost + deliveryFee + handlingFee);
}

 
 public static void Main(string[] args)
    {
      
      method_overload2 meth_over2 = new method_overload2();

      Console.WriteLine("Calculate Cost"+ meth_over2.CalculateCost(20, 5, 0));
      
    }
  } 
