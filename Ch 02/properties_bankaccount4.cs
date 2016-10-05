// created on 12/21/2002 at 1:33 PM
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
      balance=value;
    }
  }
}

class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
//code omitted for brievity..
  }
}
