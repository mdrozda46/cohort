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

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.Abba(a,b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.MakeTags(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.InsertWord(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string name, string expected)
        {
            //Act
            string actual = _strings.MultipleEndings(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string name, string expected)
        {
            //Act
            string actual = _strings.FirstHalf(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOneTest(string name, string expected)
        {
            //Act
            string actual = _strings.TrimOne(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddleTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.LongInMiddle(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void Rotateleft2Test(string name, string expected)
        {
            //Act
            string actual = _strings.Rotateleft2(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2Test(string str, string expected)
        {
            //Act
            string actual = _strings.RotateRight2(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOneTest(string a, bool b, string expected)
        {
            //Act
            string actual = _strings.TakeOne(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwoTest(string str, string expected)
        {
            //Act
            string actual = _strings.MiddleTwo(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLyTest(string str, bool expected)
        {
            //Act
            bool actual = _strings.EndsWithLy(str);

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

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        [TestCase("", "@@")]
        public void AtFirstTest(string str, string expected)
        {
            //Act
            string actual = _strings.SwapLast(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        public void LastCharsTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.LastChars(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCatTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.ConCat(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLastTest(string str, string expected)
        {
            //Act
            string actual = _strings.SwapLast2(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain(string str, bool expected)
        {
            //Act
            bool actual = _strings.FrontAgain(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCatTest(string a, string b, string expected)
        {
            //Act
            string actual = _strings.MinCat(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFrontTest(string str, string expected)
        {
            //Act
            string actual = _strings.TweakFront(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripXTest(string str, string expected)
        {
            //Act
            string actual = _strings.StripX(str);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

    
