﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warmups;
using NUnit.Framework;
using NUnit.Framework.Constraints;


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

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTableTest(int yourStyle, int dateStyle, int expected)
        {
            //Act
            int actual = _logic.CanHazTable(yourStyle, dateStyle);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutsideTest(int temp, bool isSummer, bool expected)
        {
            //Act
            bool actual = _logic.PlayOutside(temp, isSummer);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeedingTest(int speed, bool isBrithday, int expected)
        {
            //Act
            int actual = _logic.CaughtSpeeding(speed, isBrithday);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSumTest(int a, int b, int expected)
        {
            //Act
            int actual = _logic.SkipSum(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        public void SkipSumTest(int day, bool vacation, string expected)
        {
            //Act
            string actual = _logic.AlarmClock(day, vacation);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSixTest(int a, int b, bool expected)
        {
            //Act
            bool actual = _logic.LoveSix(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        public void InRangeTest(int n, bool outsideMode, bool expected)
        {
            //Act
            bool actual = _logic.InRange(n, outsideMode);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialElevenTest(int n, bool expected)
        {
            //Act
            bool actual = _logic.SpecialEleven(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(222, true)]
        public void Mod20Test(int n, bool expected)
        {
            //Act
            bool actual = _logic.Mod20(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35Test(int n, bool expected)
        {
            //Act
            bool actual = _logic.Mod35(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCellTest(bool isMorning, bool isMom, bool isAsleep, bool expected)
        {
            //Act
            bool actual = _logic.AnswerCell(isMorning, isMom, isAsleep);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void TwoIsOneTest(int a, int b, int c, bool expected)
        {
            //Act
            bool actual = _logic.TwoIsOne(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void AreInOrderTest(int a, int b, int c, bool bOk, bool expected)
        {
            //Act
            bool actual = _logic.AreInOrder(a, b, c, bOk);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqualTest(int a, int b, int c, bool bOk, bool expected)
        {
            //Act
            bool actual = _logic.InOrderEqual(a, b, c, bOk);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        public void LastDigitTest(int a, int b, int c, bool expected)
        {
            //Act
            bool actual = _logic.LastDigit(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}