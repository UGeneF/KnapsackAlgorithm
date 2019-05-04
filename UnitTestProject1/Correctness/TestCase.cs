using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.Tests.Correctness
{
    public class TestCase
    {
        public List<Item> AllItems { get; set; }
        public Knapsack Knapsack { get; set; }
        public List<Item> ExpectedItems { get; set; }

        public TestCase(double knapsackWeight, List<Item> allItems, params int[] expectedItems)
        {
            Knapsack = new Knapsack(knapsackWeight);
            AllItems = allItems;
            ExpectedItems = allItems.GetItemsAtPositions(expectedItems);
        }
    }
}