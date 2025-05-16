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

            Assert.That(pizza.NameOfDish, Is.EqualTo("�����"));
            Assert.That(pizza.Kitchen, Is.EqualTo(KitchenName.�����������));
            Assert.That(pizza.AboutTheDish, Is.EqualTo("����� � ��������"));
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
            Assert.That(info[0], Is.EqualTo("��������: �����"));
            Assert.That(info[1], Is.EqualTo("�����: �����������"));
            Assert.That(info[2], Is.EqualTo("��������: ����� � ��������"));
            Assert.That(info[3], Is.EqualTo("����: 40 ���."));
            Assert.That(info[4], Is.EqualTo("�������: � �������"));
            Assert.That(info[5], Is.EqualTo("����� �������������: 20 �����"));

        }

        private Dish CreateTestDish()
        {
            return new Dish("�����", KitchenName.�����������, "����� � ��������", 40, true, 20);
        }
    }
}