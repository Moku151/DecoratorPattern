using CoffeeShop.AbstractClasses;

namespace CoffeeShop.Beverages
{
    internal class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf";
        }

        public override float Cost()
        {
            return 1.05f;
        }
    }
}
