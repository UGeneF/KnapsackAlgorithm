using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.Tests.Correctness
{
    public static class CorrectnessTestCases
    {
        public static CorrectnessTestCase FewExpensiveAndManyChipItems = new CorrectnessTestCase(5, new List<Item>
        {
            new Item(1, 15),
            new Item(5, 1),
            new Item(3, 10),
            new Item(3, 3),
            new Item(3, 4),
            new Item(4, 5)
        }, 25);

        public static CorrectnessTestCase OneExpensiveAndTwoChipItemsWithGreatestSumCost = new CorrectnessTestCase(6, new List<Item>
        {
            new Item(3, 2),
            new Item(4, 3),
            new Item(3, 2),
        }, 4);

        public static CorrectnessTestCase ZeroCostWhenNotEnoughWeight = new CorrectnessTestCase(2, new List<Item>
        {
            new Item(3, 2),
            new Item(4, 3),
            new Item(3, 2),
        }, 0);

        public static CorrectnessTestCase GoldenCase = new CorrectnessTestCase(10, new List<Item>
        {
            new Item(5, 10),
            new Item(4, 40),
            new Item(6, 30),
            new Item(3, 50),
        }, 90);

        public static CorrectnessTestCase ZeroCostWhenNoItems = new CorrectnessTestCase(10, new List<Item>
        {
        }, 0);
    }
}