namespace KnapsackAlgorithm.Entities
{
    public class Item
    {
        public double Weight { get; }
        public double Cost { get; }
        public double UnitCost { get; private set; }

        public Item(double weight, double cost)
        {
            Weight = weight;
            Cost = cost;
        }

        public void EvaluateUnitCost()
        {
            UnitCost = Cost / Weight;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}; Cost: {Cost}; Hash: {GetHashCode()}";
        }
    }
}