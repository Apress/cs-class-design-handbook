
using System;

public class Account
{
  private double balance;
  private int passcode;

  public int PIN
  {
  
   set
    {
      passcode=value;
    }
  }

  public double Balance
  {
    get
    {
      return balance;
    }
    set
    {
      if (value < 0)
        throw new ArgumentOutOfRangeException("value","Balance must be greater than 0");
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
      myAccount.PIN=8745;
      int myPIN=myAccount.PIN;
      Console.WriteLine("Your PIN is:" + myAccount.PIN);
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
    }
    Console.ReadLine();
  }
}
