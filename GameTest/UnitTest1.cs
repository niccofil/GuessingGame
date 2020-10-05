using GuessingGame;
using NUnit.Framework;
using System.Globalization;

namespace GameTest
{
    public class Tests
    {
        [Test]

        public void NumbersComparisonHigh()
        {
            bool compare = Comparison.CompareNumbers(6, 4);

            Assert.IsFalse(compare);
        }

        [Test]

        public void NumbersComparisonLow()
        {
            bool compare1 = Comparison.CompareNumbers(3, 4);

            Assert.IsFalse(compare1);
        }

        [Test]

        public void NumbersComparisonEqual()
        {
            bool compare2 = Comparison.CompareNumbers(4, 4);

            Assert.IsTrue(compare2);
        }

    }
}