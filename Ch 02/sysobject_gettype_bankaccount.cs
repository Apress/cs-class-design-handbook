// created on 12/21/2002 at 1:39 PM
using System;

public class Account
{

}

class AtTheBank
{
  [STAThread]
  static void Main(string[] args)
  {
    Account myAccount= new Account();
  
    Console.WriteLine("myAccount is an object of type : " + 
                       myAccount.GetType());
  }
}
