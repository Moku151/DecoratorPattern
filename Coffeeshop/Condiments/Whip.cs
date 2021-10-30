using CoffeeShop.AbstractClasses;

namespace CoffeeShop.Condiments
{
    internal class Whip : Condiment
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Whip";
        }

        public override float Cost()
        {
            return base.Cost() + 0.2f;
        }
    }
}
