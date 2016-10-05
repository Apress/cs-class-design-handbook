using System;

namespace parameter_types
{
  public class Calculator
  {
    public static decimal CalculateInterest(decimal balance)
    {
      decimal interest = (decimal)45.11;
      balance = balance + interest;
      return (balance);
    }
  }
  
  class BatchRun
  {
    static void Main()
    {
      decimal balance = (decimal)4566.54;

      Console.WriteLine("Balance = " + balance);
      Console.WriteLine("Balance + Interest = " + Calculator.CalculateInterest(balance));
      Console.WriteLine("Balance = " + balance);

    
    }
  }
}
