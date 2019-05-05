using NUnit.Framework;

namespace KnapsackAlgorithm.Tests.Correctness
{
    [TestFixture]
    public class CorrectnessTests
    {
        [Test]
        public void ShouldSelectExpensiveItemsAmongManyChip()
        {
            PackingAssert(CorrectnessTestCases.FewExpensiveAndManyChipItems);
        }

        [Test]
        public void ShouldPreferTwoChipItemsWithHightSumCostToOneExpensive()
        {
            PackingAssert(CorrectnessTestCases.OneExpensiveAndTwoChipItemsWithGreatestSumCost);
        }

        [Test]
        public void ShouldReturnZeroCostWhenNotEnoughWeight()
        {
            PackingAssert(CorrectnessTestCases.ZeroCostWhenNotEnoughWeight);
        }

        [Test]
        public void ShouldWorkCorrectOnGoldenCase()
        {
            PackingAssert(CorrectnessTestCases.GoldenCase);
        }

        [Test]
        public void ShouldReturnZeroCostWhenNoItems()
        {
            PackingAssert(CorrectnessTestCases.ZeroCostWhenNoItems);
        }

        private void PackingAssert(CorrectnessTestCase testCase)
        {
            var greatestCost =
                PackingAlgorithm.GetItemsWithGreatestCost(testCase.AllItems, testCase.Knapsack);
            Assert.AreEqual(testCase.ExpectedGreatestCost, greatestCost);
        }
    }
}