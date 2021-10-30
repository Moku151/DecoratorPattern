using CoffeeShop.AbstractClasses;

namespace CoffeeShop.Condiments
{
    internal class Milk : Condiment
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Milk";
        }

        public override float Cost()
        {
            return base.Cost() + 0.1f;
        }
    }
}
