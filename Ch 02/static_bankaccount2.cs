// created on 12/21/2002 at 1:37 PM
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

  public static void addTen()
  {
    balance=balance+10;
  }
}

class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account mySavings= new Account();
    Account myChecking=new Account();

    mySavings.Balance=500;
    Account.addTen();

    Console.WriteLine("Savings balance: " + mySavings.Balance);
    Console.WriteLine("Checking balance: " + myChecking.Balance);
  }
}
