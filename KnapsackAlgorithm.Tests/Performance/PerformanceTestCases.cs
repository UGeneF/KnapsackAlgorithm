namespace KnapsackAlgorithm.Tests.Performance
{
    public static class PerformanceTestCases
    {
        private const int Seed = 42;
        public static PerformanceTestCase KnapsackWeight10ItemsCount20 = new PerformanceTestCase(10, 20, Seed);
        public static PerformanceTestCase KnapsackWeight100ItemsCount200 = new PerformanceTestCase(100, 200, Seed);
        public static PerformanceTestCase KnapsackWeight1000ItemsCount2000 = new PerformanceTestCase(1000, 2000, Seed);
        public static PerformanceTestCase KnapsackWeight10000ItemsCount20000 = new PerformanceTestCase(10000, 20000, Seed);
        public static PerformanceTestCase KnapsackWeight100000ItemsCount200000 = new PerformanceTestCase(100000, 200000, Seed);
    }
}