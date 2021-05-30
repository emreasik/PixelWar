using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public class Battery:Weapon, IPotion
    {
        public Battery(Game game, Point location)
            : base(game, location) { Used = false; }

        public bool Used { get; private set; }

        public override string Name { get { return "Battery"; } }
        public override void Attack(Direction direction, Random random)
        {
            if (!Used) //Tek kullanabilmesi için
            {
                game.IncreasePlayerHealth(15, random);
                Used = true;
            }
            
        }
    }
}
