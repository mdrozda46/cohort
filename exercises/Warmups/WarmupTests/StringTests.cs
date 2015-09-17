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
            string actual = _strings.SayHi(name);

            Assert.AreEqual(expected, actual);
        }
    }
}

    
