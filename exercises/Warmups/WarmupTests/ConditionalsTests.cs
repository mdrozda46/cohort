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

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]

        public void Makes10Test(int a, int b, bool expected)
        {
            //Act
            bool actual = _conditionals.Makes10(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]

        public void NearHundredTest(int n, bool expected)
        {
            //Act
            bool actual = _conditionals.NearHundred(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]

        public void PosNegTest(int a, int b, bool negative, bool expected)
        {
            //Act
            bool actual = _conditionals.PosNeg(a, b, negative);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]

        public void NotStringTest(string s, string expected)
        {
            //Act
            string actual = _conditionals.NotString(s);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]

        public void MissingCharTest(string str, int n, string expected)
        {
            //Act
            string actual = _conditionals.MissingChar(str, n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]

        public void FrontBackTest(string str, string expected)
        {
            //Act
            string actual = _conditionals.FrontBack(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]

        public void BackAroundTest(string str, string expected)
        {
            //Act
            string actual = _conditionals.BackAround(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase(" high up", false)]

        public void StartHiTest(string str, bool expected)
        {
            //Act
            bool actual = _conditionals.StartHi(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]

        public void IcyHotTest(int temp1, int temp2, bool expected)
        {
            //Act
            bool actual = _conditionals.IcyHot(temp1, temp2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]

        public void Between10and20Test(int a, int b, bool expected)
        {
            //Act
            bool actual = _conditionals.Between10and20(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]

        public void HasTeenTest(int a, int b, int c, bool expected)
        {
            //Act
            bool actual = _conditionals.HasTeen(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]

        public void SoAloneTest(int a, int b, bool expected)
        {
            //Act
            bool actual = _conditionals.SoAlone(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]

        public void RemoveDelTest(string str, string expected)
        {
            //Act
            string actual = _conditionals.RemoveDel(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]

        public void IxStartTest(string str, bool expected)
        {
            //Act
            bool actual = _conditionals.IxStart(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]

        public void StartOzTest(string str, string expected)
        {
            //Act
            string actual = _conditionals.StartOz(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]

        public void MaxTest(int a, int b, int c, int expected)
        {
            //Act
            int actual = _conditionals.Max(a, b, c);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]

        public void CloserTest(int a, int b, int expected)
        {
            //Act
            int actual = _conditionals.Closer(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]

        public void GotETest(string str, bool expected)
        {
            //Act
            bool actual = _conditionals.GotE(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]

        public void EndUpTest(string str, string expected)
        {
            //Act
            string actual = _conditionals.EndUp(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]

        public void EveryNthTest(string str, int n, string expected)
        {
            //Act
            string actual = _conditionals.EveryNth(str, n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
