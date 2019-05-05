using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.Tests.Correctness
{
    public class TestCase
    {
        public List<Item> AllItems { get; set; }
        public Knapsack Knapsack { get; set; }
        public double ExpectedGreatestCost { get; set; }

        public TestCase(int knapsackWeight, List<Item> allItems, double expectedGreatestCost)
        {
            Knapsack = new Knapsack(knapsackWeight);
            AllItems = allItems;
            ExpectedGreatestCost = expectedGreatestCost;
        }
    }
}