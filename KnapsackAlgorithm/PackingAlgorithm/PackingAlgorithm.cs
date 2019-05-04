using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnapsackAlgorithm.Entities;

namespace KnapsackAlgorithm.PackingAlgorithm
{
    public static class PackingAlgorithm
    {
        public static List<Item> GetItemsWithGreatestCost(List<Item> allItems, Knapsack knapsack)
        {
            EvaluateUnitCost(allItems);
            var allItemsEnumerator = GetEnumeratorOverOrderedItems(allItems);

            while (knapsack.IsVacantWeight() && ItemsNotEnded(allItemsEnumerator))
            {
                knapsack.AddItem(allItemsEnumerator.Current);
            }

            return knapsack.Items;
        }

        private static bool ItemsNotEnded(IEnumerator<Item> allItemsEnumerator)
        {
            return allItemsEnumerator.MoveNext();
        }

        private static IEnumerator<Item> GetEnumeratorOverOrderedItems(List<Item> allItems)
        {
            return allItems.OrderByDescending(item => item.UnitCost).GetEnumerator();
        }

        private static void EvaluateUnitCost(List<Item> items)
        {
            Parallel.ForEach(items, item => item.EvaluateUnitCost());
        }
    }
}