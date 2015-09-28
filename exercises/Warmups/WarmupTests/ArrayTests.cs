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

        [TestCase(new int[] { 1, 2, 3 }, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1 }, true)]
        
        public void SameFirstLastTest(int[] numbers, bool expected)
        {
            //Act
            bool actual = _arrays.SameFirstLast(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 3, 1, 4 })]

        public void MakePiTest(int n, int[] expected)
        {
            //Act
            int[] actual = _arrays.MakePi(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, true)]

        public void commonEndTest(int[] a, int[] b, bool expected)
        {
            //Act
            bool actual = _arrays.commonEnd(a,b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7, 0, 0 }, 7)]

        public void SumTest(int[] numbers, int expected)
        {
            //Act
            int actual = _arrays.Sum(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]

        public void RotateLeftTest(int[] numbers, int[] expected)
        {
            //Act
            int [] actual = _arrays.RotateLeft(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]

        public void ReverseTest(int[] numbers, int[] expected)
        {
            //Act
            int[] actual = _arrays.Reverse(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [TestCase(new int[] { 11, 5, 9 }, new int[] { 11, 11, 11 })]
        [TestCase(new int[] { 2, 11, 3 }, new int[] { 3, 3, 3 })]

        public void HigherWinsTest(int[] numbers, int[] expected)
        {
            //Act
            int[] actual = _arrays.HigherWins(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }, new int[] { 7, 8 })]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4 })]

        public void GetMiddleTest(int[] a, int[] b, int[] expected)
        {
            //Act
            int[] actual = _arrays.GetMiddle(a,b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 5}, true)]
        [TestCase(new int[] { 4, 3 }, true)]
        [TestCase(new int[] { 7, 3 }, false)]

        public void HasEvenTest(int[] numbers, bool expected)
        {
            //Act
            bool actual = _arrays.HasEven(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]

        public void KeepLastTest(int[] numbers, int[] expected)
        {
            //Act
            int[] actual = _arrays.KeepLast(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]

        public void Double23Test(int[] numbers, bool expected)
        {
            //Act
            bool actual = _arrays.Double23(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 })]

        public void Fix23Test(int[] numbers, int[] expected)
        {
            //Act
            int[] actual = _arrays.Fix23(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1, 1, 1 }, false)]

        public void Unlucky1Test(int[] numbers, bool expected)
        {
            //Act
            bool actual = _arrays.Unlucky1(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4 }, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] { }, new int[] { 1, 2 }, new int[] { 1, 2 })]

        public void make2Test(int[] a, int[] b, int[] expected)
        {
            //Act
            int[] actual = _arrays.make2(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}