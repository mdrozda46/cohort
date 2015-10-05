﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    public class WeightedComputerPlayer : Player
    {

        private static Random _randomGenerator = new Random();

        public WeightedComputerPlayer(string Name) : base(Name)
        {
        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 11);

            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    return Choice.Rock;
                case 8:
                case 9:
                    return Choice.Scissors;
                default:
                    return Choice.Paper;
            }
        }
    }
}
