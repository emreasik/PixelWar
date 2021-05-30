using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public class Kameha:Weapon   
    {
        public Kameha(Game game, Point location) : base(game,location) { }

        public override string Name { get { return "Kameha"; } }
        public override void Attack(Direction direction, Random random)
        {
            if (!DamageEnemy(direction, 20, 6, random))
            {
                Direction nextAttackDirection = CounterClockWiseDirection(direction);
                for (int i = 0; i < 3; i++)
                {
                    if (DamageEnemy(nextAttackDirection, 20, 6, random))
                    {
                        break;
                    }
                    nextAttackDirection = CounterClockWiseDirection(direction);
                }
            }
        }
    }
}
