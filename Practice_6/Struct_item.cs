using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_6
{
    enum ItemCategory
    {
        Electronics,
        Furniture,
        Food
    }
    struct Item
    {
        public string Name;
        public int Quantity;
        public double Price;
        public ItemCategory Category;

        public void Display()
        {
            Console.WriteLine($"Назва: {Name}, Кількість: {Quantity}, Ціна: {Price}, Категорія: {Category}");
        }
    }
}
