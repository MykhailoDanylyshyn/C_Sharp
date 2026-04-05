using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_6
{
    class Warehouse
    {
        private Item[] items;
        private int count;

        public Warehouse(int size)
        {
            items = new Item[size];
            count = 0;
        }

        public void AddItem(Item item)
        {
            if (count >= items.Length)
            {
                Item[] newItems = new Item[items.Length + 1];

                for (int i = 0; i < items.Length; i++)
                {
                    newItems[i] = items[i];
                }

                items = newItems;
            }

            items[count] = item;
            count++;
        }

        public void RemoveItem(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Name == name)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    Console.WriteLine("Товар видалено.");
                    return;
                }
            }
            Console.WriteLine("Товар не знайдено.");
        }

        public void UpdateItem(string name, int quantity, double price)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Name == name)
                {
                    items[i].Quantity = quantity;
                    items[i].Price = price;
                    Console.WriteLine("Товар оновлено.");
                    return;
                }
            }
            Console.WriteLine("Товар не знайдено.");
        }

        public void DisplayItems()
        {
            if (count == 0)
            {
                Console.WriteLine("Склад порожній.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                items[i].Display();
            }
        }
    }
}
