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
    public class LogicTests
    {
        private Logic _logic;

        [SetUp]
        public void BeforeEachTest()
        {
            _logic = new Logic();
        }

        [TestCase(30, false, false)]
        [TestCase(30, true, false)]
        [TestCase(50, false, true)]
        [TestCase(50, true, true)]
        [TestCase(70, false, false)]
        [TestCase(70, true, true)]



        public void FirstLast6Test(int number, bool weekend, bool expected)
        {
            //Act
            bool actual = _logic.GreatParty(number, weekend);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}