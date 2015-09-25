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

        public void EveryOtherTest(string str, bool expected)
        {
            //Act
            bool actual = _loops.EveryOther(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}