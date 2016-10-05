// created on 12/21/2002 at 1:46 PM

using System;
public class Account
{
  private double balance;
  private int pin;

  public Account(double startingBalance, int PIN)
  {
    balance=startingBalance;
    pin=PIN;
  }

  public override int GetHashCode()
  {
    return pin;
  }
}
class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount = new Account(500,1234);
     Console.WriteLine(myAccount.GetHashCode());
  	Console.ReadLine();
  }
}
