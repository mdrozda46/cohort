using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKataTests
{
    [TestFixture]

    public class StringCalculatorTests
    {

        private StringCalculator _stringCalculator;

        [SetUp]
        public void BeforeEachTest()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyString_RetunrZero()
        {
            
            int result = _stringCalculator.Add("");

            Assert.AreEqual(0, result);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Add_OneNumber_ReturnSelf(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1,2", 3)]
        [TestCase("2,3", 5)]
        public void Add_TwoNumber_ReturnSum(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }


        [TestCase("1,2,3", 6)]
        [TestCase("4,5,6,7", 22)]
        public void Add_UnknownNumbers_ReturnSum(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1\n2, 3", 6)]
        [TestCase("1\n2\n4",7)]
        public void Add_NumberswithNewLineSum(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("//;\n1;2", 3)]
        [TestCase("//$\n3$4\n5", 12)]
        public void Add_NumbersWithCustomDelimiterSum(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("-1,2", -1)]
        [TestCase("2,-4,3,-5", -1)]
        public void NegativeNotSupported(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("1001,2", 2)]
        public void IgnoreLargeNumbers(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("//[***]\n1***2***3", 6)]
        [TestCase("//[$$$$]\n1$$$$2$$$$4", 7)]
        public void AnyLengthDelimeter(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }

       /* [TestCase("//[*][%]\n1*2%3", 6)]
        public void MulitpleDelimeters(string numbers, int expectedResult)
        {
            int result = _stringCalculator.Add(numbers);

            Assert.AreEqual(expectedResult, result);
        }*/

    }
}
