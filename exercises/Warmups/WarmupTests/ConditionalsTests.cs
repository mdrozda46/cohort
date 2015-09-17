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
    }
}
