using System.Collections.Generic;
using System.Linq;

namespace KnapsackAlgorithm.Tests
{
    public static class ListExtensions
    {
        public static List<T> GetItemsAtPositions<T>(this List<T> list, IEnumerable<int> positions)
        {
            return positions.Select(position => list[position]).ToList();
        }
    }
}