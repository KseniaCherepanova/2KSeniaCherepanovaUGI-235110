using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDish
{
    public class Dish
    {
        public readonly RestaurantName Name;
        public NameOfKitchen Kitchen{ get; set; }
        public decimal Price { get; set; }
        public DishExistence Existence{  get; set; }
        public int CookingTime { get; set; }

        public Dish(RestaurantName name, NameOfKitchen kitchen, decimal price, DishExistence existence, int cookingTime)
        {
            Name = name;
            Kitchen = kitchen;
            Price = price;  
            Existence = existence;
            CookingTime = cookingTime;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"Название: {Name}";
            info[1] = $"Кухня: {Kitchen}";

            string existence;
            if (Existence == DishExistence.yes)
                existence = "в наличии";
            else
                existence = "нет в наличии";

            info[2] = $"Цена: {Price}. Время приготовления: {CookingTime} минут. Наличие: {existence}";
            return info;

        }
        

    }
}
