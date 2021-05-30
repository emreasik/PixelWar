using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public abstract class Enemy : Mover, ISprite
    {
        private const int NearPlayerDistance = 55; //Enemy deki nesnelerin gemimize vurma uzaklığı
        private int hitPoints;

        public int HitPoints { get { return hitPoints; } }
        public Size SpriteSize { get; private set; }

        public bool Dead //Düşmanın ölü oluğ olmadığını kontrol eder.
        {
            get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }

        public Enemy(Game game, Point location, int hitPoints, Size spriteSize)
                : base(game, location)
        {
            this.hitPoints = hitPoints;
            SpriteSize = spriteSize;
        }

        public abstract void Move(Random random); //Enemy den kalıtılan classlar bu metodu override eder.

        public void Hit(int maxDamage, Random random) //canı azalıyor
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer() //Oyuncunun menzili içerisinde oluğ olmadığını kontrol eder.
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }
        
        protected Direction FindPlayerDirection(Point playerLocation)  //Game de tanımlanan oyuncunun location'ı burda moverdan gelen değerle kıyaslanıp return ediliyor.
        {                                                              //Düşmanların bize yaklaşmasını sağlar player'ın hareketine göre.
            Direction directionToMove;
            if (playerLocation.X > location.X + 10) directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10) directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10) directionToMove = Direction.Up;
            else directionToMove = Direction.Down;

            return directionToMove;
        }
    }
}
