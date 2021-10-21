using NUnit.Framework;

namespace IndiciesOfTwoNumbersTests
{
    public class IndiciesOfTwoNumbersTests
    {

        [Test]
        [TestCase(new int[] { 2, 3, 5, 6, 9 }, 15, new int[2] { 3,4 })]
        [TestCase(new int[] { 2, 3, 5, 6, 9 }, 19, null)]
        [TestCase(new int[] { 2, 3 }, 5, new int[2] { 0, 1 })]
        [TestCase(new int[] { 2 }, 2, null)]
        [TestCase(new int[] {} , 2, null)]
        public void FindTwoPairSumBruteForce_WithPossibleSolution_ReturnsSolution(int[] numbers, int target, int[]  expectedResult)
        {
            var result = IndiciesOfTwoNumbers.BruteForceSolution.FindTwoPairSum(numbers, target);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(new int[] { 2, 3, 5, 6, 9 }, 15, new int[2] { 3, 4 })]
        [TestCase(new int[] { 2, 3, 5, 6, 9 }, 19, null)]
        [TestCase(new int[] { 2, 3 }, 5, new int[2] { 0, 1 })]
        [TestCase(new int[] { 2 }, 2, null)]
        [TestCase(new int[] { }, 2, null)]
        public void FindTwoPairSumEffective_WithPossibleSolution_ReturnsSolution(int[] numbers, int target, int[] expectedResult)
        {
            var result = IndiciesOfTwoNumbers.EffectiveSolution.FindTwoPairSum(numbers, target);
            Assert.AreEqual(expectedResult, result);
        }
    }
}