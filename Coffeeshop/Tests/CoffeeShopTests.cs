using CoffeeShop.Beverages;
using CoffeeShop.Condiments;
using NUnit.Framework;

namespace CoffeeShop.Tests
{
    internal class CoffeeShopTests
    {
        [Test]
        public void PureEspresso()
        {
            var beverage = new Espresso();
            Assert.AreEqual("Espresso", beverage.GetDescription());
            Assert.AreEqual(1.99f, beverage.Cost());
        }

        [Test]
        public void DecafMilkSoyAndWhip()
        {
            var beverage = new Whip(new Soy(new Milk(new Decaf())));
            Assert.AreEqual("Decaf, Milk, Soy, Whip", beverage.GetDescription());
            Assert.AreEqual(1.50f, beverage.Cost());
        }

        [Test]
        public void EspressoWithMilkAndDoubleWhip()
        {
            var beverage = new Whip(new Whip(new Milk(new Espresso())));
            Assert.AreEqual("Espresso, Milk, Whip, Whip", beverage.GetDescription());
            Assert.AreEqual(2.49f, beverage.Cost());
        }
    }
}
