using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.PackingAlgorithm
{
    public static class PackingAlgorithm
    {
        public static double GetItemsWithGreatestCost(List<Item> allItems, Knapsack knapsack)
        {
            var knapsacksMatrix = new double[allItems.Count + 1, knapsack.TotalWeight + 1];
            for (int item = 1; item < knapsacksMatrix.GetLength(0); item++)
            {
                for (int weight = 1; weight <knapsacksMatrix.GetLength(1); weight++)
                {
                    var currentItem = allItems[item - 1];
                    var prevValueForThisWeight = knapsacksMatrix[item - 1, weight];
                    var remainingWeight = weight - currentItem.Weight;
                    if (remainingWeight >= 0)
                    {
                        var maxValueInRemainingWeight = knapsacksMatrix[item - 1, remainingWeight];
                        var valueWithThisItem = maxValueInRemainingWeight + currentItem.Cost;
                        var currentWeightMaxValue = Math.Max(prevValueForThisWeight, valueWithThisItem);
                        knapsacksMatrix[item, weight] = currentWeightMaxValue;
                    }
                    else
                    {
                        knapsacksMatrix[item, weight] = prevValueForThisWeight;
                    }
                }
            }

            return knapsacksMatrix[allItems.Count, knapsack.TotalWeight];
        }

    }
}