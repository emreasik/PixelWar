namespace PixelWar2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AttackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AttackUp = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HitPointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPointsCaption = new System.Windows.Forms.Label();
            this.GhostHitPointsCaption = new System.Windows.Forms.Label();
            this.GhoulHitPointsCaption = new System.Windows.Forms.Label();
            this.PlayerHitPoints = new System.Windows.Forms.Label();
            this.BatHitPoints = new System.Windows.Forms.Label();
            this.GhostHitPoints = new System.Windows.Forms.Label();
            this.GhoulHitPoints = new System.Windows.Forms.Label();
            this.invBatterySprite = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.invSunSprite = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.invKamehaSprite = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.invFireSprite = new System.Windows.Forms.PictureBox();
            this.SpiderSprite = new System.Windows.Forms.PictureBox();
            this.AlienSprite = new System.Windows.Forms.PictureBox();
            this.BossSprite = new System.Windows.Forms.PictureBox();
            this.ShipSprite = new System.Windows.Forms.PictureBox();
            this.FireSprite = new System.Windows.Forms.PictureBox();
            this.SunSprite = new System.Windows.Forms.PictureBox();
            this.KamehaSprite = new System.Windows.Forms.PictureBox();
            this.BatterySprite = new System.Windows.Forms.PictureBox();
            this.levelLbl1 = new System.Windows.Forms.Label();
            this.levelLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.AttackPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.HitPointPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invBatterySprite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invSunSprite)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invKamehaSprite)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invFireSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpiderSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlienSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KamehaSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatterySprite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 184);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 168);
            this.panel1.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel1);
            this.groupBox7.Font = new System.Drawing.Font("Pixelmania", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(683, 2);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(163, 160);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "MOVE";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(145, 112);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(42, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(5, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Left";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(78, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Right";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.button4, 2);
            this.button4.Location = new System.Drawing.Point(36, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AttackPanel);
            this.groupBox3.Font = new System.Drawing.Font("Pixelmania", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(850, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(169, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ATTACK";
            // 
            // AttackPanel
            // 
            this.AttackPanel.ColumnCount = 2;
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AttackPanel.Controls.Add(this.AttackUp, 0, 0);
            this.AttackPanel.Controls.Add(this.AttackLeft, 0, 1);
            this.AttackPanel.Controls.Add(this.AttackRight, 1, 1);
            this.AttackPanel.Controls.Add(this.AttackDown, 0, 2);
            this.AttackPanel.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackPanel.Location = new System.Drawing.Point(16, 35);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.RowCount = 3;
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.AttackPanel.Size = new System.Drawing.Size(140, 112);
            this.AttackPanel.TabIndex = 17;
            // 
            // AttackUp
            // 
            this.AttackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackUp, 2);
            this.AttackUp.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackUp.Location = new System.Drawing.Point(26, 6);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(87, 24);
            this.AttackUp.TabIndex = 1;
            this.AttackUp.Text = "Up";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackLeft.Location = new System.Drawing.Point(4, 43);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(61, 24);
            this.AttackLeft.TabIndex = 2;
            this.AttackLeft.Text = "Left";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackRight.Location = new System.Drawing.Point(74, 43);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(61, 24);
            this.AttackRight.TabIndex = 3;
            this.AttackRight.Text = "Right";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackDown, 2);
            this.AttackDown.Location = new System.Drawing.Point(33, 81);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(74, 24);
            this.AttackDown.TabIndex = 4;
            this.AttackDown.Text = "Down";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HitPointPanel);
            this.groupBox2.Controls.Add(this.invBatterySprite);
            this.groupBox2.Font = new System.Drawing.Font("Pixelmania", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(284, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HEALTH";
            // 
            // HitPointPanel
            // 
            this.HitPointPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HitPointPanel.ColumnCount = 2;
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.HitPointPanel.Controls.Add(this.PlayerHitPointsCaption, 0, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPointsCaption, 0, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPointsCaption, 0, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPointsCaption, 0, 3);
            this.HitPointPanel.Controls.Add(this.PlayerHitPoints, 1, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPoints, 1, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPoints, 1, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPoints, 1, 3);
            this.HitPointPanel.Font = new System.Drawing.Font("Minecraft", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitPointPanel.Location = new System.Drawing.Point(5, 35);
            this.HitPointPanel.Name = "HitPointPanel";
            this.HitPointPanel.RowCount = 4;
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.HitPointPanel.Size = new System.Drawing.Size(179, 110);
            this.HitPointPanel.TabIndex = 23;
            // 
            // PlayerHitPointsCaption
            // 
            this.PlayerHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPointsCaption.AutoSize = true;
            this.PlayerHitPointsCaption.Location = new System.Drawing.Point(4, 8);
            this.PlayerHitPointsCaption.Name = "PlayerHitPointsCaption";
            this.PlayerHitPointsCaption.Size = new System.Drawing.Size(49, 12);
            this.PlayerHitPointsCaption.TabIndex = 0;
            this.PlayerHitPointsCaption.Text = "Player";
            // 
            // BatHitPointsCaption
            // 
            this.BatHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPointsCaption.AutoSize = true;
            this.BatHitPointsCaption.Location = new System.Drawing.Point(4, 35);
            this.BatHitPointsCaption.Name = "BatHitPointsCaption";
            this.BatHitPointsCaption.Size = new System.Drawing.Size(49, 12);
            this.BatHitPointsCaption.TabIndex = 1;
            this.BatHitPointsCaption.Text = "Spider";
            // 
            // GhostHitPointsCaption
            // 
            this.GhostHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPointsCaption.AutoSize = true;
            this.GhostHitPointsCaption.Location = new System.Drawing.Point(4, 62);
            this.GhostHitPointsCaption.Name = "GhostHitPointsCaption";
            this.GhostHitPointsCaption.Size = new System.Drawing.Size(37, 12);
            this.GhostHitPointsCaption.TabIndex = 2;
            this.GhostHitPointsCaption.Text = "Alien";
            // 
            // GhoulHitPointsCaption
            // 
            this.GhoulHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPointsCaption.AutoSize = true;
            this.GhoulHitPointsCaption.Location = new System.Drawing.Point(4, 89);
            this.GhoulHitPointsCaption.Name = "GhoulHitPointsCaption";
            this.GhoulHitPointsCaption.Size = new System.Drawing.Size(36, 12);
            this.GhoulHitPointsCaption.TabIndex = 3;
            this.GhoulHitPointsCaption.Text = "Boss";
            // 
            // PlayerHitPoints
            // 
            this.PlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPoints.AutoSize = true;
            this.PlayerHitPoints.Location = new System.Drawing.Point(64, 8);
            this.PlayerHitPoints.Name = "PlayerHitPoints";
            this.PlayerHitPoints.Size = new System.Drawing.Size(109, 12);
            this.PlayerHitPoints.TabIndex = 4;
            this.PlayerHitPoints.Text = "PlayerHitPoints";
            this.PlayerHitPoints.Click += new System.EventHandler(this.PlayerHitPoints_Click);
            // 
            // BatHitPoints
            // 
            this.BatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPoints.AutoSize = true;
            this.BatHitPoints.Location = new System.Drawing.Point(64, 35);
            this.BatHitPoints.Name = "BatHitPoints";
            this.BatHitPoints.Size = new System.Drawing.Size(109, 12);
            this.BatHitPoints.TabIndex = 5;
            this.BatHitPoints.Text = "SpiderHitPoints";
            // 
            // GhostHitPoints
            // 
            this.GhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPoints.AutoSize = true;
            this.GhostHitPoints.Location = new System.Drawing.Point(64, 62);
            this.GhostHitPoints.Name = "GhostHitPoints";
            this.GhostHitPoints.Size = new System.Drawing.Size(97, 12);
            this.GhostHitPoints.TabIndex = 6;
            this.GhostHitPoints.Text = "AlienHitPoints";
            // 
            // GhoulHitPoints
            // 
            this.GhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPoints.AutoSize = true;
            this.GhoulHitPoints.Location = new System.Drawing.Point(64, 89);
            this.GhoulHitPoints.Name = "GhoulHitPoints";
            this.GhoulHitPoints.Size = new System.Drawing.Size(96, 12);
            this.GhoulHitPoints.TabIndex = 7;
            this.GhoulHitPoints.Text = "BossHitPoints";
            // 
            // invBatterySprite
            // 
            this.invBatterySprite.BackColor = System.Drawing.Color.Transparent;
            this.invBatterySprite.Image = global::PixelWar2.Properties.Resources.energy_battery;
            this.invBatterySprite.Location = new System.Drawing.Point(189, 57);
            this.invBatterySprite.Margin = new System.Windows.Forms.Padding(2);
            this.invBatterySprite.Name = "invBatterySprite";
            this.invBatterySprite.Size = new System.Drawing.Size(82, 52);
            this.invBatterySprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invBatterySprite.TabIndex = 22;
            this.invBatterySprite.TabStop = false;
            this.invBatterySprite.Visible = false;
            this.invBatterySprite.Click += new System.EventHandler(this.invBatterySprite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Pixelmania", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(382, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVENTORY";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.invSunSprite);
            this.groupBox5.Location = new System.Drawing.Point(131, 21);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(107, 126);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // invSunSprite
            // 
            this.invSunSprite.Image = global::PixelWar2.Properties.Resources.sun;
            this.invSunSprite.Location = new System.Drawing.Point(4, 24);
            this.invSunSprite.Margin = new System.Windows.Forms.Padding(2);
            this.invSunSprite.Name = "invSunSprite";
            this.invSunSprite.Size = new System.Drawing.Size(99, 93);
            this.invSunSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invSunSprite.TabIndex = 15;
            this.invSunSprite.TabStop = false;
            this.invSunSprite.Visible = false;
            this.invSunSprite.Click += new System.EventHandler(this.invSunSprite_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.invKamehaSprite);
            this.groupBox6.Location = new System.Drawing.Point(255, 21);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(107, 126);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            // 
            // invKamehaSprite
            // 
            this.invKamehaSprite.Image = global::PixelWar2.Properties.Resources.kamehameha;
            this.invKamehaSprite.Location = new System.Drawing.Point(4, 17);
            this.invKamehaSprite.Margin = new System.Windows.Forms.Padding(2);
            this.invKamehaSprite.Name = "invKamehaSprite";
            this.invKamehaSprite.Size = new System.Drawing.Size(99, 99);
            this.invKamehaSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invKamehaSprite.TabIndex = 17;
            this.invKamehaSprite.TabStop = false;
            this.invKamehaSprite.Visible = false;
            this.invKamehaSprite.Click += new System.EventHandler(this.invKamehaSprite_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.invFireSprite);
            this.groupBox4.Location = new System.Drawing.Point(4, 21);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(104, 126);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // invFireSprite
            // 
            this.invFireSprite.Image = global::PixelWar2.Properties.Resources.fire;
            this.invFireSprite.Location = new System.Drawing.Point(4, 24);
            this.invFireSprite.Margin = new System.Windows.Forms.Padding(2);
            this.invFireSprite.Name = "invFireSprite";
            this.invFireSprite.Size = new System.Drawing.Size(96, 93);
            this.invFireSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.invFireSprite.TabIndex = 18;
            this.invFireSprite.TabStop = false;
            this.invFireSprite.Visible = false;
            this.invFireSprite.Click += new System.EventHandler(this.invFireSprite_Click);
            // 
            // SpiderSprite
            // 
            this.SpiderSprite.BackColor = System.Drawing.Color.Transparent;
            this.SpiderSprite.Image = global::PixelWar2.Properties.Resources.one_eyes;
            this.SpiderSprite.Location = new System.Drawing.Point(774, 223);
            this.SpiderSprite.Margin = new System.Windows.Forms.Padding(2);
            this.SpiderSprite.Name = "SpiderSprite";
            this.SpiderSprite.Size = new System.Drawing.Size(94, 63);
            this.SpiderSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpiderSprite.TabIndex = 16;
            this.SpiderSprite.TabStop = false;
            this.SpiderSprite.Visible = false;
            // 
            // AlienSprite
            // 
            this.AlienSprite.BackColor = System.Drawing.Color.Transparent;
            this.AlienSprite.Image = global::PixelWar2.Properties.Resources.alien;
            this.AlienSprite.Location = new System.Drawing.Point(698, 343);
            this.AlienSprite.Margin = new System.Windows.Forms.Padding(2);
            this.AlienSprite.Name = "AlienSprite";
            this.AlienSprite.Size = new System.Drawing.Size(94, 87);
            this.AlienSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlienSprite.TabIndex = 15;
            this.AlienSprite.TabStop = false;
            this.AlienSprite.Visible = false;
            // 
            // BossSprite
            // 
            this.BossSprite.BackColor = System.Drawing.Color.Transparent;
            this.BossSprite.Image = global::PixelWar2.Properties.Resources.boss_ship;
            this.BossSprite.Location = new System.Drawing.Point(817, 343);
            this.BossSprite.Margin = new System.Windows.Forms.Padding(2);
            this.BossSprite.Name = "BossSprite";
            this.BossSprite.Size = new System.Drawing.Size(93, 87);
            this.BossSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BossSprite.TabIndex = 14;
            this.BossSprite.TabStop = false;
            this.BossSprite.Visible = false;
            // 
            // ShipSprite
            // 
            this.ShipSprite.BackColor = System.Drawing.Color.Transparent;
            this.ShipSprite.Image = global::PixelWar2.Properties.Resources.main_ship;
            this.ShipSprite.Location = new System.Drawing.Point(66, 209);
            this.ShipSprite.Margin = new System.Windows.Forms.Padding(2);
            this.ShipSprite.Name = "ShipSprite";
            this.ShipSprite.Size = new System.Drawing.Size(101, 77);
            this.ShipSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShipSprite.TabIndex = 13;
            this.ShipSprite.TabStop = false;
            // 
            // FireSprite
            // 
            this.FireSprite.BackColor = System.Drawing.Color.Transparent;
            this.FireSprite.Image = global::PixelWar2.Properties.Resources.energy_fire_skill;
            this.FireSprite.Location = new System.Drawing.Point(179, 60);
            this.FireSprite.Margin = new System.Windows.Forms.Padding(2);
            this.FireSprite.Name = "FireSprite";
            this.FireSprite.Size = new System.Drawing.Size(68, 61);
            this.FireSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FireSprite.TabIndex = 17;
            this.FireSprite.TabStop = false;
            this.FireSprite.Visible = false;
            // 
            // SunSprite
            // 
            this.SunSprite.BackColor = System.Drawing.Color.Transparent;
            this.SunSprite.Image = global::PixelWar2.Properties.Resources.essence_of_the_sun;
            this.SunSprite.Location = new System.Drawing.Point(259, 60);
            this.SunSprite.Margin = new System.Windows.Forms.Padding(2);
            this.SunSprite.Name = "SunSprite";
            this.SunSprite.Size = new System.Drawing.Size(68, 61);
            this.SunSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SunSprite.TabIndex = 18;
            this.SunSprite.TabStop = false;
            this.SunSprite.Visible = false;
            // 
            // KamehaSprite
            // 
            this.KamehaSprite.BackColor = System.Drawing.Color.Transparent;
            this.KamehaSprite.Image = global::PixelWar2.Properties.Resources.kameha;
            this.KamehaSprite.Location = new System.Drawing.Point(338, 60);
            this.KamehaSprite.Margin = new System.Windows.Forms.Padding(2);
            this.KamehaSprite.Name = "KamehaSprite";
            this.KamehaSprite.Size = new System.Drawing.Size(68, 61);
            this.KamehaSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KamehaSprite.TabIndex = 19;
            this.KamehaSprite.TabStop = false;
            this.KamehaSprite.Visible = false;
            // 
            // BatterySprite
            // 
            this.BatterySprite.BackColor = System.Drawing.Color.Transparent;
            this.BatterySprite.Image = global::PixelWar2.Properties.Resources.energy_battery;
            this.BatterySprite.Location = new System.Drawing.Point(427, 69);
            this.BatterySprite.Margin = new System.Windows.Forms.Padding(2);
            this.BatterySprite.Name = "BatterySprite";
            this.BatterySprite.Size = new System.Drawing.Size(81, 52);
            this.BatterySprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatterySprite.TabIndex = 21;
            this.BatterySprite.TabStop = false;
            this.BatterySprite.Visible = false;
            // 
            // levelLbl1
            // 
            this.levelLbl1.AutoSize = true;
            this.levelLbl1.BackColor = System.Drawing.Color.Transparent;
            this.levelLbl1.Font = new System.Drawing.Font("Minecraft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl1.ForeColor = System.Drawing.SystemColors.Info;
            this.levelLbl1.Location = new System.Drawing.Point(900, 29);
            this.levelLbl1.Name = "levelLbl1";
            this.levelLbl1.Size = new System.Drawing.Size(80, 24);
            this.levelLbl1.TabIndex = 21;
            this.levelLbl1.Text = "Level";
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.BackColor = System.Drawing.Color.Transparent;
            this.levelLbl.Font = new System.Drawing.Font("Minecraft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.levelLbl.Location = new System.Drawing.Point(991, 29);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(25, 24);
            this.levelLbl.TabIndex = 22;
            this.levelLbl.Text = "8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PixelWar2.Properties.Resources.area_last125;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1050, 691);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.levelLbl1);
            this.Controls.Add(this.FireSprite);
            this.Controls.Add(this.SpiderSprite);
            this.Controls.Add(this.AlienSprite);
            this.Controls.Add(this.BossSprite);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ShipSprite);
            this.Controls.Add(this.BatterySprite);
            this.Controls.Add(this.SunSprite);
            this.Controls.Add(this.KamehaSprite);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelWar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.AttackPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.HitPointPanel.ResumeLayout(false);
            this.HitPointPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invBatterySprite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invSunSprite)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invKamehaSprite)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invFireSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpiderSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlienSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BossSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KamehaSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatterySprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox invKamehaSprite;
        private System.Windows.Forms.PictureBox invSunSprite;
        private System.Windows.Forms.PictureBox invFireSprite;
        private System.Windows.Forms.PictureBox SpiderSprite;
        private System.Windows.Forms.PictureBox AlienSprite;
        private System.Windows.Forms.PictureBox BossSprite;
        private System.Windows.Forms.PictureBox ShipSprite;
        private System.Windows.Forms.PictureBox FireSprite;
        private System.Windows.Forms.PictureBox SunSprite;
        private System.Windows.Forms.PictureBox KamehaSprite;
        private System.Windows.Forms.PictureBox BatterySprite;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox invBatterySprite;
        private System.Windows.Forms.TableLayoutPanel AttackPanel;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.TableLayoutPanel HitPointPanel;
        private System.Windows.Forms.Label PlayerHitPointsCaption;
        private System.Windows.Forms.Label BatHitPointsCaption;
        private System.Windows.Forms.Label GhostHitPointsCaption;
        private System.Windows.Forms.Label GhoulHitPointsCaption;
        private System.Windows.Forms.Label PlayerHitPoints;
        private System.Windows.Forms.Label BatHitPoints;
        private System.Windows.Forms.Label GhostHitPoints;
        private System.Windows.Forms.Label GhoulHitPoints;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label levelLbl1;
        private System.Windows.Forms.Label levelLbl;
    }
}

