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
    public class ConditionalsTests
    {
        private Conditionals _conditionals;

        [SetUp]
        public void BeforeEachTest()
        {
            _conditionals= new Conditionals();
        }

        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        [TestCase(false, false, true)]

        public void AreWeInTroubleTest(bool a, bool b, bool expected)
        {
            //Act
            bool actual = _conditionals.AreWeInTrouble(a,b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]

        public void CanSleepInTest(bool a, bool b, bool expected)
        {
            //Act
            bool actual = _conditionals.CanSleepIn(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]

        public void SumDoubleTest(int a, int b, int expected)
        {
            //Act
            int actual = _conditionals.SumDouble(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]

        public void SDiff21Test(int a, int expected)
        {
            //Act
            int actual = _conditionals.Diff21(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]

        public void ParrotTroubleTest(bool isTalking, int hour, bool expected)
        {
            //Act
            bool actual = _conditionals.ParrotTrouble(isTalking, hour);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
