using System;

public class Calculator
{
  public static decimal CalculateInterest(out decimal balance)
  {
    decimal interest = (decimal)45.11;
    balance = (decimal)4566.54;
    balance += interest;
    return (balance);
  }
}
  
class BatchRun
{
  static void Main()
  {
    decimal balance;

    Console.WriteLine("Balance + Interest = " + Calculator.CalculateInterest(out balance));
  }
} 
