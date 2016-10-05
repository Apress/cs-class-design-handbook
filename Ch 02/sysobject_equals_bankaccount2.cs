// created on 12/21/2002 at 1:42 PM
using System;

public class Account
{
  private double balance;

  public Account(double startingBalance)
  {
    balance=startingBalance;
  }
public override bool Equals(object obj)
  {
    if ((obj == null) || (GetType() != obj.GetType()))
      return false;
    Account acct=(Account)obj;
    return acct.balance == balance;
  }
}

class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount = new Account(500);
    Account mySavings = new Account(500);
  
    Console.WriteLine(myAccount.Equals(mySavings));
  }
}
