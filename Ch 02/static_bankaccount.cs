// created on 12/21/2002 at 1:36 PM
using System;

public class Account
{
  private static double balance;

  public double Balance
  {
    get
    {
      return balance;
    }
    set
    {
      balance=value;
    }
  }
}

class atthebank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account mySavings= new Account();
    Account myChecking=new Account();

    mySavings.Balance=500;

    Console.WriteLine("Savings balance: " + mySavings.Balance);
    Console.WriteLine("Checking balance: " + myChecking.Balance);
  }
} 
