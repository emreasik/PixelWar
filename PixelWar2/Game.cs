using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelWar2
{
    public class Game
    {
        public List<Enemy> Enemies; // Birden fazla enemy tutmamızı sağlar
        public Weapon WeaponInRoom; // Silahları eklememezi sağlar
        public Battery PotionInRoom;

        private Player player; // Player Class ından oyuncu oluşturup game de eriştik.
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } } //Oyuncunun canını tutar
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        public Size PlayerSpriteSize { get { return player.SpriteSize; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries; // Oyun alanını tutması için Rectangle class'ından nesne oluşturduk.
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries) // Oyundaki gemimizi oluşturduk ve konumunu belirledik.
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 15, boundaries.Top + 150), new Size(148, 119));

        }

        public void Move(Direction direction, Random random) //Form1.cs'teki buton clicklerden gelen değerler buraya aktarılır. Player'a yönlendirir ordan Movera gider return olur.
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                if (!enemy.Dead)
                {
                    enemy.Move(random); // Form1.cs'ten gelen değerler enemy clasındaki move metoduna yollanır.
                }
                
        }

        public void Equip(string weaponName) //Tıklanan weapon'ı player sınıfına yollar.
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName); //Contains gelen weaponName'in geçtiği değeri true döndürür
        }

        public bool CheckPotionUsed(string potionName)
        {
            return player.CheckPotionUsed(potionName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    enemy.Move(random);
                }
            }
        }


        private Point GetRandomLocationEnemies(Random random) //Düşmanlar için Random Konum
        {
            Point location = new Point(random.Next(boundaries.X + 480, boundaries.X + 905), random.Next(boundaries.Y + 30, boundaries.Y + 395));
            return location;
        }

        public Point GetRandomLocationSkills(Random random) //Weapon ve Battery için Random Konum
        {
            Point location = new Point(random.Next(boundaries.X + 50, boundaries.X + 400), random.Next(boundaries.Y + 30, boundaries.Y + 218));
            return location;
        }

        public void NewLevel(Random random) //Oyunun level'ı artar ve ona göre Weapon ve Enemy Ekler
        {
            level++;
            switch (level)
            {
                case 0:                    
                    Application.Exit();
                    break;
                case 1:
                    MessageBox.Show("Don't forget!\nYou can move with W,A,S, and D keys.\nAttack with I,J,K, and L.\nSelect items with 1,2,3 and 4(For battery).");
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Spider(this, GetRandomLocationEnemies(random), new Size(125,78)));
                    Enemies.Add(new Alien(this, GetRandomLocationEnemies(random), new Size(125, 107)));
                    WeaponInRoom = new Fire(this, GetRandomLocationSkills(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Alien(this, GetRandomLocationEnemies(random), new Size(125,107)));
                    WeaponInRoom = new Battery(this, GetRandomLocationSkills(random));                    
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Boss(this, GetRandomLocationEnemies(random), new Size (125,107)));
                    WeaponInRoom = new Sun(this, GetRandomLocationSkills(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Spider(this, GetRandomLocationEnemies(random), new Size (125,78)));
                    Enemies.Add(new Alien(this, GetRandomLocationEnemies(random), new Size(125, 107)));
                    WeaponInRoom = null;
                    if (!CheckPlayerInventory("Sun"))
                    {
                        WeaponInRoom = new Sun(this, GetRandomLocationSkills(random));
                    }
                    else
                    {
                        WeaponInRoom = new Battery(this, GetRandomLocationSkills(random));
                    }
                    break;
                    
                case 5:
                    Enemies.Clear();
                    Enemies.Add(new Spider(this, GetRandomLocationEnemies(random), new Size(125, 78)));
                    Enemies.Add(new Alien(this, GetRandomLocationEnemies(random), new Size(125, 107)));
                    WeaponInRoom = new Kameha(this, GetRandomLocationSkills(random));
                    break;
                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Alien(this, GetRandomLocationEnemies(random), new Size(125, 107)));
                    break;
                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Spider(this, GetRandomLocationEnemies(random), new Size(125, 78)));
                    Enemies.Add(new Alien(this, GetRandomLocationEnemies(random), new Size(125, 107)));
                    Enemies.Add(new Boss(this, GetRandomLocationEnemies(random), new Size(125, 107)));
                    if (CheckPlayerInventory("Kameha"))
                    {
                        if (!CheckPlayerInventory("Battery")
                                || (CheckPlayerInventory("Battery")
                                    && CheckPotionUsed("Battery")))
                        {
                            WeaponInRoom = new Battery(this, GetRandomLocationSkills(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Kameha(this, GetRandomLocationSkills(random));
                    }
                    level = -1;
                    break;

            }
        }

    }
    }
