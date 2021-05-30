using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelWar2
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(25, 21, 910, 400));
            game.NewLevel(random);
            UpdateCharacters();           
        }

        private void LevelLbl() // level label'ında bulundunduğumuz level'i gönderiyor.
        {
            levelLbl.Text = game.Level.ToString();
            if(game.Level==-1)
            {
                levelLbl.Text = "7";
            }
        }

        private void SelectInventoryItem(PictureBox itemSprite, string itemName, string weaponType)
        {
            if (game.CheckPlayerInventory(itemName))
            {
                game.Equip(itemName);
                RemoveInventorySpriteBorders();
                itemSprite.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(weaponType);
            }
        }

        private void RemoveInventorySpriteBorders() // İtemlerin alındığını belli etmek için görsel değişiyoruz 
        {
            invFireSprite.BorderStyle = BorderStyle.None;
            invBatterySprite.BorderStyle = BorderStyle.None;
            invSunSprite.BorderStyle = BorderStyle.None;
            invKamehaSprite.BorderStyle = BorderStyle.None;
            invKamehaSprite.Image = Properties.Resources.kamehameha;
            invSunSprite.Image = Properties.Resources.sun;
            invFireSprite.Image = Properties.Resources.fire;


        }

        private void SetupAttackButtons(string weaponType) // Butonların Düzenlemesini yapıyor Drink veya Attack tuşları için
        {
            switch (weaponType.ToLower())
            {
                case "weapon":
                    AttackUp.Text = "Up";
                    AttackRight.Visible = true;
                    AttackDown.Visible = true;
                    AttackLeft.Visible = true;
                    break;
                case "potion":
                    AttackUp.Text = "Charge";
                    AttackRight.Visible = false;
                    AttackDown.Visible = false;
                    AttackLeft.Visible = false;
                    break;
            }
        }

        public bool UpdateEnemySprite(Enemy enemy, PictureBox enemySprite, Label enemyHitPoints)
        {
            bool enemySpriteUpdated = false;

            if (enemy.HitPoints > 0) // Canın eksiye düşmesini engeller.
            {
                enemyHitPoints.Text = enemy.HitPoints.ToString();

            }
            else
                enemyHitPoints.Text = "Dead";            

            if (enemy.HitPoints > 0)
            {
                enemySprite.Location = enemy.Location;
                enemySprite.Visible = true;
                enemySpriteUpdated = true;
            }
            else
            {
                enemySprite.Visible = false;
            }

            return enemySpriteUpdated;
        }

        public void UpdateCharacters()
        {
            LevelLbl();
            ShipSprite.Location = game.PlayerLocation;
            PlayerHitPoints.Text = game.PlayerHitPoints.ToString();

            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Spider)
                {
                    if (UpdateEnemySprite(enemy, SpiderSprite, BatHitPoints))
                    {
                        enemiesShown++;
                    }
                }
                if (enemy is Alien)
                {
                    if (UpdateEnemySprite(enemy, AlienSprite, GhostHitPoints))
                    {
                        enemiesShown++;
                    }
                }
                if (enemy is Boss)
                {
                    if (UpdateEnemySprite(enemy, BossSprite, GhoulHitPoints))
                    {
                        enemiesShown++;
                    }
                }
            }

            FireSprite.Visible = false;
            SunSprite.Visible = false;
            KamehaSprite.Visible = false;
            BatterySprite.Visible = false;
 

            if (game.WeaponInRoom != null)
            {
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
                {
                    case "Fire":
                        weaponControl = FireSprite;
                        break;
                    case "Sun":
                        weaponControl = SunSprite;
                        break;
                    case "Kameha":
                        weaponControl = KamehaSprite;
                        break;
                    case "Battery":
                        weaponControl = BatterySprite;
                        break;
                    
                }

                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
                {
                    weaponControl.Visible = true;
                    weaponControl.Location = game.WeaponInRoom.Location;
                }
            }
            invFireSprite.Visible = false;
            invSunSprite.Visible = false;
            invKamehaSprite.Visible = false;
            invBatterySprite.Visible = false;

            if (game.CheckPlayerInventory("Fire"))
            {
                invFireSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Sun"))
            {
                invSunSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Kameha"))
            {
                invKamehaSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Battery"))
            {
                if (!game.CheckPotionUsed("Battery"))
                {
                    invBatterySprite.Visible = true;
                }
            }


            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }


            if (enemiesShown < 1) {
                if(game.Level<8  && game.Level>0)
                {
                    MessageBox.Show("LEVEL COMPLETE!");
                }
                else if(game.Level==-1)
                {
                    MessageBox.Show("You WIN!");
                }
                game.NewLevel(random);
                UpdateCharacters();
            }
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void invFireSprite_Click(object sender, EventArgs e) //Form üzerinden tıklayınca metoda paramtreleri gönderir.
        {
            SelectInventoryItem(invFireSprite, "Fire", "weapon");
            invFireSprite.Image = Properties.Resources.energy_fire_skill;
        }

        private void invSunSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(invSunSprite, "Sun", "weapon");
            invSunSprite.Image = Properties.Resources.essence_of_the_sun;
        }

        private void invKamehaSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(invKamehaSprite, "Kameha", "weapon");
            invKamehaSprite.Image = Properties.Resources.kameha;
        }

        private void invBatterySprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(invBatterySprite, "Battery", "potion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {
            if (AttackUp.Text=="Charge") //Görüntünün düzelmesi için
            {
                SetupAttackButtons("weapon");
            }
            
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //Klavyeden oynamamızı sağlıyor. Hareket için WASD, Saldırı için IJKL, İtem seçimi içi 1,2,3, Potion için 4.
        {
            if(e.KeyCode == Keys.W)
            {
                game.Move(Direction.Up, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.A)
            {
                game.Move(Direction.Left, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.D)
            {
                game.Move(Direction.Right, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.S)
            {
                game.Move(Direction.Down, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.I)
            {
                game.Attack(Direction.Up, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.J)
            {
                game.Attack(Direction.Left, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.L)
            {
                game.Attack(Direction.Right, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.K)
            {
                game.Attack(Direction.Down, random);
                UpdateCharacters();

            }
            else if (e.KeyCode == Keys.D1)
            {
                SelectInventoryItem(invFireSprite, "Fire", "weapon");
                invFireSprite.Image = Properties.Resources.energy_fire_skill;
            }
            else if (e.KeyCode == Keys.D2)
            {
                SelectInventoryItem(invSunSprite, "Sun", "weapon");
                invSunSprite.Image = Properties.Resources.essence_of_the_sun;
            }
            else if (e.KeyCode == Keys.D3)
            {
                SelectInventoryItem(invKamehaSprite, "Kameha", "weapon");
                invKamehaSprite.Image = Properties.Resources.kameha;
            }
            else if (e.KeyCode == Keys.D4)
            {
                SelectInventoryItem(invBatterySprite, "Battery", "potion");
            }
        }

        private void PlayerHitPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
    