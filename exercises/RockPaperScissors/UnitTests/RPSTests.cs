using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;
using UnitTests.Implementation;

namespace UnitTests
{
    [TestFixture]
    public class RPSTests
    {
        private Game _game;


        [SetUp]
        public void BeforeEachTest()
        {

            _game = new Game();

        }

        [TestCase(Choice.Rock, Result.Win)]
        [TestCase(Choice.Paper, Result.Tie)]
        [TestCase(Choice.Scissors, Result.Loss)]
        public void PaperPlayerTest(Choice choice, Result expected)
        {
            //Setup
            AlwaysPaperPlayer p1 = new AlwaysPaperPlayer("Paper Player");
            Player p2;

            switch (choice)
            {
                case Choice.Rock:
                    p2 = new AlwaysRockPlayer("Rock Player");
                    break;
                case Choice.Scissors:
                    p2 = new AlwaysScissorPlayer("Scissors Player");
                    break;
                default:
                    p2 = new AlwaysPaperPlayer("Paper Player");
                    break;
             }

            //Act
            Result actual = _game.PlayRound(p1, p2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
