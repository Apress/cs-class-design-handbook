using System;
using System.Data;

public class Account
{
  public static DataSet GetAllAccounts()
  {
    return (new DataSet());
  }

  public void DepositMoney(decimal amount, string accountNumber)
  {
    if (this.validateAccount(accountNumber))
    {
      // Deposit Money to the correct account
    }
  }

  private bool validateAccount(string accountNumber)
  {
    return true;  // Assume Account Number is ok
  }
}

public class Payments
{
  static void Main()
  {
    DataSet dsAccountList = Account.GetAllAccounts();

    Account account = new Account();
    account.DepositMoney((decimal)249.99, "56329SVZ");
  }
}
