using CoffeeShop.AbstractClasses;

namespace CoffeeShop.Condiments
{
    internal class Soy : Condiment
    {
        public Soy(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Soy";
        }

        public override float Cost()
        {
            return base.Cost() + 0.15f;
        }
    }
}
