using System;
using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.Tests.Performance
{
    public class PerformanceTestCase
    {
        public List<Item> AllItems { get; }
        public Knapsack Knapsack { get; }

        public PerformanceTestCase(int knapsackWeight, int itemsCount, int randomSeed)
        {
            AllItems=new List<Item>(itemsCount);
            Knapsack = new Knapsack(knapsackWeight);
            GenerateRandomItems(itemsCount, randomSeed);
        }

        private void GenerateRandomItems(int itemsCount, int randomSeed)
        {
            var random = new Random(randomSeed);
            for (var i = 0; i < itemsCount; i++)
            {
                AllItems.Add(new Item(random.Next() % 100, random.NextDouble()));
            }
        }
    }
}