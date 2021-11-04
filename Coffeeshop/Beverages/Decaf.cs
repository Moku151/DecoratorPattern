using CoffeeShop.Beverages.Interfaces;

namespace CoffeeShop.Beverages
{
    internal class Decaf : IBeverage
    {
        public string GetDescription()
        {
            return "Decaf";
        }

        public float Cost()
        {
            return 1.05f;
        }
    }
}
