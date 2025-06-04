

using System.Collections;
using ClassDish;
using static ClassDish.Dish;


namespace Dishes.UnitTests
{
    [TestFixture]
    public class DishUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var karbonara = CreateTestDish();

            Assert.That(karbonara.NameOfDish, Is.EqualTo("���������"));
            Assert.That(karbonara.Kitchen, Is.EqualTo(KitchenName.�����������));
            Assert.That(karbonara.AboutTheDish, Is.EqualTo("����� � ������ ������, ����� � �������."));
            Assert.That(karbonara.Price, Is.EqualTo(40));
            Assert.That(karbonara.DishExistence, Is.EqualTo(true));
            Assert.That(karbonara.CookingTime, Is.EqualTo(20));
        }

        [Test]
        public void GetInfoTest()
        {
            var karbonara = CreateTestDish();
            var info = karbonara.GetInfo();

            Assert.That(info.Length, Is.EqualTo(6));
            Assert.That(info[0], Is.EqualTo("��������: ���������"));
            Assert.That(info[1], Is.EqualTo("�����: �����������"));
            Assert.That(info[2], Is.EqualTo("��������: ����� � ������ ������, ����� � �������."));
            Assert.That(info[3], Is.EqualTo("����: 40 ���."));
            Assert.That(info[4], Is.EqualTo("�������: � �������"));
            Assert.That(info[5], Is.EqualTo("����� �������������: 20 �����"));

        }

        private Dish CreateTestDish()
        {
            var DishMember = new Dish("���������", KitchenName.�����������, "����� � ������ ������, ����� � �������.", 40, true, 20);
            return DishMember;
        }
    }


    [TestFixture]
    public class SnackUnitTests
    {
        public class TestSnack : Snack
        {
            public TestSnack(string name, bool whatKindOfSnack, KitchenName kitchen,
                             string aboutTheDish, int price, bool dishExistence, int cookingtime)
                : base(name, whatKindOfSnack, kitchen, aboutTheDish, price, dishExistence, cookingtime)
            {
            }
        }


        [Test]
        public void ConstructorTest_Snack()
        {
            var julienne = CreateTestSnack();
            Assert.That(julienne.WhatKindOfSnack, Is.EqualTo(true));
        }


        [Test]
        public void GetInfoTest_SnackInfo()
        {
            var julienne = CreateTestSnack();
            var lines = new[]
            {
                "��������: ������� ������",
                "��� �������: �������",
                "�����: �����������",
                "��������: ���������� ����� � �����",
                "����: 5 ���.",
                "�������: � �������",
                "����� �������������: 15 �����"
            };

            var info = julienne.GetInfo();

            Assert.That(info.Length, Is.EqualTo(7));
            for (int i = 0; i < info.Length; i++)
            {
                Assert.That(info[i], Is.EqualTo(lines[i]));
            }
        }

        private Snack CreateTestSnack()
        {
            return new TestSnack(
                name: "������� ������",
                whatKindOfSnack: true,
                kitchen: KitchenName.�����������,
                aboutTheDish: "���������� ����� � �����",
                price: 5,
                dishExistence: true,
                cookingtime: 15
            );
        }
    }

    [TestFixture]
    public class BasicFoodUnitTests
    {
        public class TestBasicFood : BasicFood
        {
            public TestBasicFood(string name, TypeOfBasicFood typeFood, string garnish, KitchenName kitchen, string aboutTheDish, int price, bool dishExistence, int cookingtime)
             : base(name, typeFood, garnish, kitchen, aboutTheDish, price, dishExistence, cookingtime) { }
        }

        [Test]
        public void ConstructorTest_BasicFood()
        {
            var cutletWithMashedPotatoes = CreateBasicFoodTests();
            Assert.That(cutletWithMashedPotatoes.TypeFood, Is.EqualTo(TypeOfBasicFood.����));
            Assert.That(cutletWithMashedPotatoes.Garnish, Is.EqualTo("����"));
        }

        [Test]
        public void GetInfoTest_BasicFoodInfo()
        {
            var cutletWithMashedPotatoes = CreateBasicFoodTests();
            var lines = new[]
            {
                "��������: ������� � ����",
                "��� ��������� ��������: ����",
                "������: ����",
                "�����: �������",
                "��������: ��� �����, ��������� �� ������� ������ ������ � ������� ������������� ����",
                "����: 30 ���.",
                "�������: � �������",
                "����� �������������: 30 �����"
            };

            var info = cutletWithMashedPotatoes.GetInfo();

            Assert.That(info.Length, Is.EqualTo(8));
            for (int i = 0; i < info.Length; i++)
            {
                Assert.That(info[i], Is.EqualTo(lines[i]));
            }
        }

        private BasicFood CreateBasicFoodTests()
        {
            return new TestBasicFood(
                name: "������� � ����",
                typeFood: TypeOfBasicFood.����,
                garnish: "����",
                kitchen: KitchenName.�������,
                aboutTheDish: "��� �����, ��������� �� ������� ������ ������ � ������� ������������� ����",
                price: 30,
                dishExistence: true,
                cookingtime: 30
            );
        }
    }


    [TestFixture]
    public class DishesTests
    {
        [Test]
        public void CompareToTest()
        {
            var lagman = new Dish("������", KitchenName.���������������, "����� � ����� � �������", 30, true, 30);
            var plov = new Dish("����", KitchenName.���������������, "��� � ����� � ��������", 45, true, 20);
            var borscht = new Dish("����", KitchenName.���������, "��� �� ������ � �������", 60, true, 15);
            var shashlik = new Dish("������", KitchenName.����������, "������� ���� �� �������", 40, true, 25);
            var khachapuri = new Dish("��������", KitchenName.����������, "������ ����", 20, true, 10);

            Assert.That(lagman.CompareTo(borscht), Is.LessThan(0)); // ��������������� ����� ���������
            Assert.That(plov.CompareTo(shashlik), Is.GreaterThan(0)); // ��������������� ����� ����������
            Assert.That(shashlik.CompareTo(khachapuri), Is.GreaterThan(0)); // ��� �� ���������� � ��������� �� ��������
        }
    }



    [TestFixture]
    public class MenuTests
    {
        Menu menu;
        Dish[] fewDishes;

        [SetUp]
        public void SetUp()
        {
            var lagman = new Dish("������", KitchenName.���������������, "����� � ����� � �������", 30, true, 30);
            var plov = new Dish("����", KitchenName.���������������, "��� � ����� � ��������", 45, true, 20);
            var borscht = new Dish("����", KitchenName.���������, "��� �� ������ � �������", 60, true, 15);
            var shashlik = new Dish("������", KitchenName.����������, "������� ���� �� �������", 40, true, 25);
            var khachapuri = new Dish("��������", KitchenName.����������, "������ ����", 20, true, 10);

            fewDishes = new Dish[] { lagman, plov, borscht, shashlik, khachapuri };
            menu = new Menu("28.05.2025", fewDishes);

        }

        [Test]
        public void IEnumerableTest()
        {
            int i = 0;

            foreach (var dish1 in menu)
                Assert.That(dish1, Is.SameAs(fewDishes[i++]));
        }

    }
}



