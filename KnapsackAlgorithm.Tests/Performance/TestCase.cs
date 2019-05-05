using System;
using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.Tests.Performance
{
    public class PerformanceTest
    {
        public List<Item> AllItems { get; } = new List<Item>();
        public Knapsack Knapsack { get; }

        public double Actual { get; }

        public PerformanceTest(int knapsackWeight, int randomSeed, int itemsCount, double actual)
        {
            var r = new Random(randomSeed);
            for (var i = 0; i < itemsCount; i++)
            {
                AllItems.Add(new Item(r.Next() % 100, r.NextDouble() * 10));
            }

            Actual = actual;
            Knapsack = new Knapsack(knapsackWeight);
        }
    }
}