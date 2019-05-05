namespace KnapsackAlgorithm.Entities
{
    public class Item
    {
        public int Weight { get; }
        public double Cost { get; }

        public Item(int weight, double cost)
        {
            Weight = weight;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}; Cost: {Cost}; Hash: {GetHashCode()}";
        }
    }
}