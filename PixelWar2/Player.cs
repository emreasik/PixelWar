using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    public class Player : Mover, ISprite
    {
        private Weapon equippedWeapon;
        private int hitPoints;

        public int HitPoints { get { return hitPoints; } }
        public Size SpriteSize { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons //Oyuncunun envanterinde silahları tutmasını sağlar ama sadece birini o an kullanabilir
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Player(Game game, Point location, Size spriteSize) //game de player tanımlarken location girdik base olarak kullandığımız için aynı değer mover a gitti.
                : base(game, location)
        {
            hitPoints = 10; //Can değerimiz
            SpriteSize = spriteSize;
        }

        public void Hit(int maxDamage, Random random) //Game den gelen canavar hit ini canımızdan azaltır.
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random) //Random can arttırıyor.
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName) //Envanterden seçilen şeyleri alır. Game de kullanıyoruz.
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 80)) // İtem alma aralığımız
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
            }
            
        }


        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random); //Weapon class'ına iletiyor.
            }
        }

        public bool CheckPotionUsed(string potionName)
        {
            IPotion potion;
            bool potionUsed = true;

            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == potionName && weapon is IPotion) // potion name aynıysa ve IPotion a atise true dönecek.
                {
                    potion = weapon as IPotion;
                    potionUsed = potion.Used;
                }
            }

            return potionUsed;
        }
    }
}
