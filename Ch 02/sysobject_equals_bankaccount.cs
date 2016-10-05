// created on 12/21/2002 at 1:41 PM
using System;

public class Account
{
  private double balance;

  public Account(double startingBalance)
  {
    balance=startingBalance;
  }
}

class atthebank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount = new Account(500);
    Account mySavings = new Account(500);
  
    Console.WriteLine(myAccount.Equals(mySavings));
    mySavings=myAccount;
    Console.WriteLine(myAccount.Equals(mySavings));
  }
}
