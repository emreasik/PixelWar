using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public class Sun:Weapon
    {
        public Sun(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "Sun"; } }
        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 30, 1, random);
        }
    }
}
