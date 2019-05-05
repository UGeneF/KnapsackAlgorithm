using NUnit.Framework;

namespace KnapsackAlgorithm.Tests.Correctness
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

        [Test]
        public void ShouldReturnNoItemsWhenNotEnoughWeight()
        {
            PackingAssert(TestCases.NoItemsWhenNotEnoughWeight);
        }

        [Test]
        public void ShouldReturnCorrectResultOnSimpleTestCase()
        {
            PackingAssert(TestCases.SimpleTestCase);
        }

        [Test]
        public void ShouldReturnNoItemsOnSimpleTestCase2()
        {
            PackingAssert(TestCases.SimpleTestCase2);
        }

        private void PackingAssert(TestCase testCase)
        {
            var greatestCost =
                PackingAlgorithm.PackingAlgorithm.GetItemsWithGreatestCost(testCase.AllItems, testCase.Knapsack);
            Assert.AreEqual(testCase.ExpectedGreatestCost, greatestCost);
        }
    }
}