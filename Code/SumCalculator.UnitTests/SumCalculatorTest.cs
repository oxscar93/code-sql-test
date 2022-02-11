using NUnit.Framework;
using SumNumbers.Parsers;
using System.Collections.Generic;

namespace SumCalculator.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumTwoNumsWithSameLengthWillbe777777()
        {
            List<int> num1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> num2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            var result = SumNumbers.Calculators.SumCalculator.Sum(num1, num2);

            Assert.AreEqual(777777, result.ToInt());       
        }

        [Test]
        public void SumTwoNumsWithDifferentLength666666()
        {
            List<int> num1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> num2 = new List<int> { 1, 2, 3, 4, 5};

            var result = SumNumbers.Calculators.SumCalculator.Sum(num1, num2);

            Assert.AreEqual(666666, result.ToInt());
        }
    }
}