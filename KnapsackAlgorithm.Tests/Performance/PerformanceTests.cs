using NUnit.Framework;

namespace KnapsackAlgorithm.Tests.Performance
{
    [TestFixture]
    public class PerformanceTests
    {
        [Test]
        public void ShouldWarmup()
        {
            PackingAssert(TestCases.WarmUpTest);
        }

        [Test]
        public void ShouldPerformanceTest()
        {
            PackingAssert(TestCases.FirstPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest2()
        {
            PackingAssert(TestCases.SecondPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest3()
        {
            PackingAssert(TestCases.ThirdPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest4()
        {
            PackingAssert(TestCases.FourthPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest5()
        {
            PackingAssert(TestCases.FifthPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest6()
        {
            PackingAssert(TestCases.SixthPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest7()
        {
            PackingAssert(TestCases.SeventhPerformanceTest);
        }
        [Test]
        public void ShouldPerformanceTest8()
        {
            PackingAssert(TestCases.EighthPerformanceTest);
        }

        private void PackingAssert(PerformanceTest testCase)
        {
            var greatestCost =
                PackingAlgorithm.PackingAlgorithm.GetItemsWithGreatestCost(testCase.AllItems, testCase.Knapsack);
            Assert.AreEqual(greatestCost, testCase.Actual);
        }
    }
}