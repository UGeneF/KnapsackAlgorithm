using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using KnapsackAlgorithm.Entities;
using NUnit.Framework;

namespace KnapsackAlgorithm.Tests.Performance
{
    [TestFixture]
    public class PerformanceTests
    {
        [Test, Order(1)]
        public void TranslateMethodToMachineCode()
        {
            PackingAlgorithm.GetItemsWithGreatestCost(new List<Item>(), new Knapsack(0));
        }

        [Test, Order(2)]
        public void GenerateTestCases()
        {
            foreach (var staticField in 
                typeof(PerformanceTestCases)
                .GetRuntimeFields()
                .Where(field => field.FieldType == typeof(PerformanceTestCase)))
            {
                staticField.GetValue(null);
            }
        }

        [Test, Order(3)]
        public void KnapsackWeight10ItemsCount20()
        {
            RunTestCase(PerformanceTestCases.KnapsackWeight10ItemsCount20);
        }

        [Test, Order(4)]
        public void KnapsackWeight100ItemsCount200()
        {
            RunTestCase(PerformanceTestCases.KnapsackWeight100ItemsCount200);
        }

        [Test, Order(5)]
        public void KnapsackWeight1000ItemsCount2000()
        {
            RunTestCase(PerformanceTestCases.KnapsackWeight1000ItemsCount2000);
        }

        [Test, Order(6)]
        public void KnapsackWeight10000ItemsCount20000()
        {
            RunTestCase(PerformanceTestCases.KnapsackWeight10000ItemsCount20000);
        }

        [Test, Order(7)]
        public void KnapsackWeight100000ItemsCount200000()
        {
            RunTestCase(PerformanceTestCases.KnapsackWeight100000ItemsCount200000);
        }

        private void RunTestCase(PerformanceTestCase testCase)
        {
            PackingAlgorithm.GetItemsWithGreatestCost(testCase.AllItems, testCase.Knapsack);
        }
    }
}