using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warmups;
using NUnit.Framework;
using Strings = Warmups.Strings;

namespace WarmupTests
{
    [TestFixture]
    public class StringTests
    {

        private Strings _strings;

        [SetUp]
        public void BeforeEachTest()
        {
            _strings = new Strings();
        }

        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            //Act
            string actual = _strings.SayHi(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBackTest(string name, int n, string expected)
        {
            //Act
            string actual = _strings.FrontAndBack(name, n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPositionTest(string name, int n, string expected)
        {
            //Act
            string actual = _strings.TakeTwoFromPosition(name, n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBadTest(string name, bool expected)
        {
            //Act
            bool actual = _strings.HasBad(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

    
