using NUnit.Framework;

namespace KnapsackAlgorithm.Tests.CorrectnessTests
{
    [TestFixture]
    public class CorrectnessTests
    {
        [Test]
        public void ShouldSelectExpensiveItemsAmongManyChip()
        {
            PackingAssert(TestCases.FewExpensiveAndManyChipItems);
        }

        [Test]
        public void ShouldPreferTwoChipItemsWithHightSumCostToOneExpensive()
        {
            PackingAssert(TestCases.OneExpensiveAndTwoChipItemsWithGreatestSumCost);
        }

        private void PackingAssert(TestCase testCase)
        {
            var actualItems = PackingAlgorithm.PackingAlgorithm.GetItemsWithGreatestCost(testCase.AllItems, testCase.Knapsack);
            CollectionAssert.AreEquivalent(testCase.ExpectedItems, actualItems);
        }
    }
}