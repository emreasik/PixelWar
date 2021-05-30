﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public class Alien:Enemy, ISprite
    {
        public Alien(Game game, Point location, Size alienSize)
            : base(game, location, 10, alienSize) { }

        public override void Move(Random random)
        {
            if (random.Next(1, 3) == 1)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            if (NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
