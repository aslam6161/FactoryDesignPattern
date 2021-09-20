using FactoryDesignPattern.CodeWithPattern;
using System;

namespace FactoryDesignPattern
{
    class Program
    {
        private static Action<string> Print;
        static void Main(string[] args)
        {
            Print = Console.WriteLine;

            //CODE WITHOUT FACTORY PATTERN
            //string cardType = "Platinum";

            //ICreditCard creditCard = null;
            //if (cardType == "Platinum")
            //    creditCard = new Platinum();
            //else if (cardType == "MoneyBack")
            //    creditCard = new MoneyBack();
            //else if (cardType == "Titanium")
            //    creditCard = new  Titanium();

            ICreditCard creditCard = CreditCardFactory.CreateCreditCard("MoneyBack");
            if (creditCard != null)
            {
                Print($"Card Type :{creditCard.GetCardType()}");
                Print($"Card Limit :{creditCard.GetCreditLimit()}");
                Print($"Annual Charge :{creditCard.GetAnnualCharge()}");
            }
            else
            {
                Print($"Invalid Card");
            }


        }
    }

}
