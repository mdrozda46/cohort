﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace UnitTests.Implementation
{
    public class AlwaysPaperPlayer : Player
    {
        public AlwaysPaperPlayer(string Name) : base(Name)
        {
        }

        public override Choice GetChoice()
        {
            return Choice.Paper;
        }
    }
}
