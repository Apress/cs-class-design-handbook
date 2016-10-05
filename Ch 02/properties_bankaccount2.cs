// created on 12/21/2002 at 1:28 PM
using System;

public class Account
{
  private double balance;

  public double Balance
  {
    get
    {
      return balance;
    }
    set
    {
        if (value < -500)
          throw 
          new ArgumentOutOfRangeException("value","Balance cannot be overdrafted by more than 500");
      balance=value;

    }
  }
}
class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount = new Account();
    
    try
    {
      Console.WriteLine("You have" + myAccount.Balance + " remaining.");
      myAccount.Balance=10000;
      Console.WriteLine("You have" + +myAccount.Balance + " remaining.");
      myAccount.Balance=-500;
      Console.WriteLine("You have" + myAccount.Balance + "  remaining.");
    }
    catch(ArgumentOutOfRangeException e)
    {
      Console.WriteLine("Bad value!");
    }
  }
}
