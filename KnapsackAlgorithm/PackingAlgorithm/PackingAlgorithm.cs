using System;
using System.Collections.Generic;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm
{
    public static class PackingAlgorithm
    {
        public static double GetMaxPossibleCost(List<Item> allItems, Knapsack knapsack)
        {
            var table = new KnapsackTable(knapsack.TotalWeight);

            foreach (var item in allItems)
            {
                ComputeMaxCostForEachWeight(knapsack, item, table);
                table.NewLine();
            }

            return table.GetResult();
        }

        private static void ComputeMaxCostForEachWeight(Knapsack knapsack, Item item, KnapsackTable table)
        {
            for (var weight = 1; weight <= knapsack.TotalWeight; weight++)
            {
                ComputeMaxCost(item, weight, table);
            }
        }

        private static void ComputeMaxCost(Item item, int weight, KnapsackTable table)
        {
            var currentItem = item;
            var prevValueForThisWeight = table.GetPrevCost(weight);
            var remainingWeight = weight - currentItem.Weight;

            if (remainingWeight >= 0)
            {
                var maxValueInRemainingWeight = table.GetPrevCost(remainingWeight);
                var valueWithThisItem = maxValueInRemainingWeight + currentItem.Cost;
                var currentWeightMaxValue = Math.Max(prevValueForThisWeight, valueWithThisItem);
                table.SetCurrentCost(weight, currentWeightMaxValue);
            }
            else
            {
                table.SetCurrentCost(weight, prevValueForThisWeight);
            }
        }
    }
}