using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warmups;
using NUnit.Framework;


namespace WarmupTests
{
    [TestFixture]
    public class ArrayTests
    {
        private Arrays _arrays;

        [SetUp]
        public void BeforeEachTest()
        {
            _arrays = new Arrays();
        }

        [TestCase(new int[] {1,2,6}, true)]
        [TestCase(new int[] {6, 1, 2, 3}, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3}, false)]



        public void FirstLast6Test(int[] numbers, bool expected)
        {
            //Act
            bool actual = _arrays.FirstLast6(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}