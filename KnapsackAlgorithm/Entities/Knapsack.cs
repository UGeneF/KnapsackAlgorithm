using System;
using System.Collections.Generic;

namespace KnapsackAlgorithm.Entities
{
    public class Knapsack
    {
        public double VacantWeight { get; private set; }
        public double TotalWeight { get; }
        public List<Item> Items { get; }

        public Knapsack(double totalWeight)
        {
            TotalWeight = totalWeight;
            VacantWeight = TotalWeight;
            Items=new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (item.Weight > VacantWeight)
            {
                return;
            }
            Items.Add(item);
            VacantWeight -= item.Weight;
        }

        public bool IsVacantWeight()
        {
            return VacantWeight > 0;
        }
    }
}