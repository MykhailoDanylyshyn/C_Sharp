using System;
using Practice_6;

try
{
    Warehouse warehouse = new Warehouse(2);

    Item item1 = new Item
    {
        Name = "Ноутбук",
        Quantity = 5,
        Price = 25000,
        Category = ItemCategory.Electronics
    };

    Item item2 = new Item
    {
        Name = "Стіл",
        Quantity = 3,
        Price = 4500,
        Category = ItemCategory.Furniture
    };

    Item item3 = new Item
    {
        Name = "Яблука",
        Quantity = 20,
        Price = 35,
        Category = ItemCategory.Food
    };

    warehouse.AddItem(item1);
    warehouse.AddItem(item2);
    warehouse.AddItem(item3);

    warehouse.DisplayItems();

    Console.WriteLine("\nОновлення товару:");
    warehouse.UpdateItem("Ноутбук", 10, 23000);
    warehouse.DisplayItems();

    Console.WriteLine("\nВидалення товару:");
    warehouse.RemoveItem("Стіл");
    warehouse.DisplayItems();
}
catch (Exception ex)
{
    Console.WriteLine($"Непередбачена помилка: {ex.Message}");
}