using CoffeeShop.Interfaces;

namespace CoffeeShop.Beverages
{
    internal class Espresso : IBeverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public float Cost()
        {
            return 1.99f;
        }
    }
}
