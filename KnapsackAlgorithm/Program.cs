using System;
using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm
{
    class Program
    {
        static void Main()
        {
            // Exit on Ctrl-C
            while (true)
            {
                Console.WriteLine("Enter the backpack capacity: ");
                var capacity = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                var items = ReadItemsFromConsole();

                WriteResultToConsole(capacity, items);
            }
        }

        private static void WriteResultToConsole(int capacity, List<Item> items)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Capacity: {capacity}");
            for (var i = 0; i < items.Count; i++)
                Console.WriteLine($"{i + 1}: {items[i].Weight}kg {items[i].Cost}$");
            var result = PackingAlgorithm.GetMaxPossibleCost(items, new Knapsack(capacity));
            Console.WriteLine($"Result: {result}$");
            Console.WriteLine("-------------------------");
        }

        private static List<Item> ReadItemsFromConsole()
        {
            Console.WriteLine("Enter item count: ");
            var itemCount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var items = new List<Item>();
            for (var i = 0; i < itemCount; i++)
            {
                Console.Write("Enter item weight, cost: ");
                var str = Console.ReadLine()?.Split(' ');
                if (str == null || str.Length < 2)
                    throw new ArgumentException();
                items.Add(new Item(int.Parse(str[0]), double.Parse(str[1])));
            }

            return items;
        }
    }
}