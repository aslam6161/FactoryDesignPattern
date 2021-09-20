using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.CodeWithPattern
{
    public static class CreditCardFactory
    {
        public static ICreditCard CreateCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if (cardType == "Platinum")
                creditCard = new Platinum();
            else if (cardType == "MoneyBack")
                creditCard = new MoneyBack();
            else if (cardType == "Titanium")
                creditCard = new Titanium();
            return creditCard;
        }
    }
}
