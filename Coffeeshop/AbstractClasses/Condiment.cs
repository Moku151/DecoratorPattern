namespace CoffeeShop.AbstractClasses
{
    internal abstract class Condiment : Beverage
    {
        private readonly Beverage _beverage;

        protected Condiment(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public override float Cost()
        {
            return _beverage.Cost();
        }
    }
}
