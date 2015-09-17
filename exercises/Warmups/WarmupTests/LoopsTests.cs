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

        public void StringTimes(string str, int num, string expected)
        {
            //Act
            string actual = _loops.StringTimes(str, num);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}