namespace FactoryDesignPattern
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1200;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 180000;
        }
    }
}
