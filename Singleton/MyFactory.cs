using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  public interface ICreditCard
  {
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
  }

  public class MoneyBack : ICreditCard
  {
    // Implementierung der ICreditCard-Methoden
    public int GetAnnualCharge()
    {
      Console.WriteLine("MoneyBack Credit Card Annual Charge: 500");
      return 500;
    }

    public string GetCardType()
    {
      Console.WriteLine("MoneyBack");
      return "Money Back";
    }

    public int GetCreditLimit()
    {
      Console.WriteLine("MoneyBack Credit Card Limit: 150000");
      return 150000;
    }
  }

  public class Titanium : ICreditCard
  {
    // Implementierung der ICreditCard-Methoden
    public int GetAnnualCharge()
    {
      Console.WriteLine("Titanium Credit Card Annual Charge: 1500");
      return 1500;
    }

    public string GetCardType()
    {
      Console.WriteLine("Titanium Edge");
      return "Titanium Edge";
    }

    public int GetCreditLimit()
    {
      Console.WriteLine("Titanium Credit Card Limit: 250000");
      return 250000;
    }
  }

  public class Platinum : ICreditCard
  {
    // Implementierung der ICreditCard-Methoden
    public int GetAnnualCharge()
    {
      Console.WriteLine("Platinum Credit Card Annual Charge: 2000");
      return 2000;
    }

    public string GetCardType()
    {
      Console.WriteLine("Platinum Plus");
      return "Platinum Plus";
    }

    public int GetCreditLimit()
    {
      Console.WriteLine("Platinum Credit Card Limit: 350000");
      return 350000;
    }
  }

  public class CreditCardFactory
  {
    public ICreditCard CreateCreditCard(string cardType)
    {
      ICreditCard creditCard = null;

      if (cardType == "MoneyBack")
      {
        creditCard = new MoneyBack();
      }
      else if (cardType == "Titanium")
      {
        creditCard = new Titanium();
      }
      else if (cardType == "Platinum")
      {
        creditCard = new Platinum();
      }

      return creditCard;
    }
  }
}
