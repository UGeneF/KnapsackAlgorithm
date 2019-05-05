using System;
using System.Collections.Generic;

namespace KnapsackAlgorithm.Entities
{
    public class Knapsack
    {
        public int TotalWeight { get; }

        public Knapsack(int totalWeight)
        {
            TotalWeight = totalWeight;
        }
    }
}