using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public class Spider:Enemy
    {
        public Spider(Game game, Point location, Size spiderSize)
            : base(game, location, 7, spiderSize) { }

        public override void Move(Random random) //location a gelen değeler mover a yönlendirilir ordan return edilir
        {
            if (random.Next(1, 2) == 1)
            {
                location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries); //Player tanımlarken location tanımlanmıştı burda o işleniyor. Mover a yollanıp return ediliyor.
            }
            else
            {
                location = Move((Direction)random.Next(1, 4), game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
