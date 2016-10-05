// created on 12/21/2002 at 1:20 PM
using System;

public class Account
{
  public double balance;
}

class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount = new Account();

    Console.WriteLine("You have " + myAccount.balance + " remaining.");
    myAccount.balance=10000;
    Console.WriteLine("You have " + myAccount.balance + " remaining.");
  }
} 
