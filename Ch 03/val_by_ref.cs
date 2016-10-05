using System;

public struct CreditCard
{
  double m_cardNumber;
  DateTime m_expiryDate;

  public double CardNumber
  {
    get
    {
      return m_cardNumber;
    }
    set
    {
      m_cardNumber = value;
    }
  }

  public DateTime ExpiryDate
  {
    get
    {
      return m_expiryDate;
    }
    set
    {
      m_expiryDate = value;
    }
  }
}

public class Authorization
{
  public static decimal GetBalance(CreditCard creditCard)
  {
    creditCard.ExpiryDate = creditCard.ExpiryDate.AddMonths(12);
    return (decimal)845.21; 
  }


public static void RenewCard(ref CreditCard creditCard)
{
  creditCard.ExpiryDate = creditCard.ExpiryDate.AddMonths(12);
}
}


class Payments
{
  static void Main()
  {
    CreditCard card = new CreditCard();
    Decimal balance;

    card.CardNumber = 1111222333444;
    card.ExpiryDate = Convert.ToDateTime("01/03/2003");

    balance = Authorization.GetBalance(card);

    Console.WriteLine("Card Number - " + card.CardNumber);
    Console.WriteLine("Expiry Date - " + card.ExpiryDate.ToShortDateString());
    Console.WriteLine("Balance     - " + balance);

    Authorization.RenewCard(ref card);    

    Console.WriteLine();
    Console.WriteLine("Card Number - " + card.CardNumber);
    Console.WriteLine("Expiry Date - " + card.ExpiryDate.ToShortDateString());
    Console.WriteLine("Balance     - " + balance);
  }
}
