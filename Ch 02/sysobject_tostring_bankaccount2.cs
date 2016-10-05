// created on 12/21/2002 at 1:41 PM
using System;

public class Account
{
  private double balance;

  public Account(double startingBalance)
  {
    balance=startingBalance;
  }

  public override string ToString()
  {
    return "Object: " + GetType() + " balance: " + balance;
  }
}

class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount= new Account(500);
  
    Console.WriteLine("ToString:" + myAccount.ToString());
  }
}
