using ClassDish;
namespace Dishes.UnitTests
{
    [TestFixture]
    public class DishUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var pizza = CreateTestDish();

            Assert.That(pizza.NameOfDish, Is.EqualTo("Пицца"));
            Assert.That(pizza.Kitchen, Is.EqualTo(KitchenName.Итальянская));
            Assert.That(pizza.AboutTheDish, Is.EqualTo("тесто с начинкой"));
            Assert.That(pizza.Price, Is.EqualTo(40));
            Assert.That(pizza.DishExistence, Is.EqualTo(true));
            Assert.That(pizza.CookingTime, Is.EqualTo(20));
        }

        [Test]
        public void GetInfoTest()
        {
            var pizza = CreateTestDish();
            var info = pizza.GetInfo();

            Assert.That(info.Length, Is.EqualTo(6));
            Assert.That(info[0], Is.EqualTo("Название: Пицца"));
            Assert.That(info[1], Is.EqualTo("Кухня: Итальянская"));
            Assert.That(info[2], Is.EqualTo("Описание: тесто с начинкой"));
            Assert.That(info[3], Is.EqualTo("Цена: 40 руб."));
            Assert.That(info[4], Is.EqualTo("Наличие: в наличии"));
            Assert.That(info[5], Is.EqualTo("Время приготовления: 20 минут"));

        }

        private Dish CreateTestDish()
        {
            return new Dish("Пицца", KitchenName.Итальянская, "тесто с начинкой", 40, true, 20);
        }
    }
}