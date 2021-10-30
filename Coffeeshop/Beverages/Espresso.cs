using CoffeeShop.AbstractClasses;

namespace CoffeeShop.Beverages
{
    internal class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override float Cost()
        {
            return 1.99f;
        }
    }
}
