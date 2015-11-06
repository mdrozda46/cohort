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
    public class LoopsTests
    {
        private Loops _loops;

        [SetUp]
        public void BeforeEachTest()
        {
           _loops = new Loops();
        }

        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int num, string expected)
        {
            //Act
            string actual = _loops.StringTimes(str, num);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimesTest(string str, int n, string expected)
        {
            //Act
            string actual = _loops.FrontTimes(str, n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXXTest(string str, int expected)
        {
            //Act
            int actual = _loops.CountXX(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleXTest(string str, bool expected)
        {
            //Act
            bool actual = _loops.DoubleX(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOtherTest(string str, string expected)
        {
            //Act
            string actual = _loops.EveryOther(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosionTest(string str, string expected)
        {
            //Act
            string actual = _loops.StringSplosion(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2Test(string str, int expected)
        {
            //Act
            int actual = _loops.CountLast2(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 9}, 1)]
        [TestCase(new int [] {1, 9, 9}, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9}, 3)]
        public void Count9Test(int[] numbers, int expected)
        {
            //Act
            int actual = _loops.Count9(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 9, 3, 4}, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9}, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5}, false)]
        public void ArrayFront9Test(int[] numbers, bool expected)
        {
            //Act
            bool actual = _loops.ArrayFront9(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]
        public void Array123Test(int[] numbers, bool expected)
        {
            //Act
            bool actual = _loops.Array123(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubStringMatchTest(string a, string b, int expected)
        {
            //Act
            int actual = _loops.SubStringMatch(a,b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringXTest(string str, string expected)
        {
            //Act
            string actual = _loops.StringX(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairsTest(string str, string expected)
        {
            //Act
            string actual = _loops.AltPairs(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYakTest(string str, string expected)
        {
            //Act
            string actual = _loops.DoNotYak(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 6, 6, 2}, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]
        public void Array667Test(int[] numbers, int expected)
        {
            //Act
            int actual = _loops.Array667(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        public void NoTriplesTest(int[] numbers, bool expected)
        {
            //Act
            bool actual = _loops.NoTriples(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1}, true)]
        public void Pattern51Test(int[] numbers, bool expected)
        {
            //Act
            bool actual = _loops.Pattern51(numbers);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}