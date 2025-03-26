using ClassDish;
using System.Xml.Linq;

namespace Dishes.UnitTests
{
    [TestFixture]
    public class DishUnitTest
    {
        [Test]
        public void ConstructorTest()
        {
            var pizza = CreateTestDish();

            Assert.That(pizza.Name, Is.EqualTo(RestaurantName.CoolRestPlace));
            Assert.That(pizza.Kitchen, Is.EqualTo(NameOfKitchen.italian));
            Assert.That(pizza.Price, Is.EqualTo(20));
            Assert.That(pizza.Existence, Is.EqualTo(DishExistence.yes));
            Assert.That(pizza.CookingTime, Is.EqualTo(40));
        }

        [Test]
        public void GetInfoTest()
        {
            var pizza = CreateTestDish();
            var info = pizza.GetInfo(); 

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Название: CoolRestPlace"));
            Assert.That(info[1], Is.EqualTo("Кухня: italian"));
            Assert.That(info[2], Is.EqualTo($"Цена: 20. Время приготовления: 40 минут. Наличие: в наличии"));
        }
        
        private Dish CreateTestDish()
        {
            return new Dish(RestaurantName.CoolRestPlace, NameOfKitchen.italian, 20, DishExistence.yes, 40);
        }
    }
}