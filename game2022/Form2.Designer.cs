namespace game2022
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            characterHPBar = new ProgressBar();
            characterHPValue = new Label();
            weapon = new Label();
            weapons = new ListBox();
            equip = new Button();
            consumables = new ListBox();
            consumable = new Button();
            label2 = new Label();
            enemyHPBar = new ProgressBar();
            label3 = new Label();
            enemyHPValue = new Label();
            label5 = new Label();
            attacks = new ListBox();
            attackButton = new Button();
            Log = new ListBox();
            SuspendLayout();
            // 
            // characterHPBar
            // 
            characterHPBar.Location = new Point(1380, 736);
            characterHPBar.Maximum = 20;
            characterHPBar.Name = "characterHPBar";
            characterHPBar.Size = new Size(417, 53);
            characterHPBar.TabIndex = 0;
            characterHPBar.Value = 20;
            // 
            // characterHPValue
            // 
            characterHPValue.AutoSize = true;
            characterHPValue.Location = new Point(1724, 713);
            characterHPValue.Name = "characterHPValue";
            characterHPValue.Size = new Size(73, 20);
            characterHPValue.TabIndex = 1;
            characterHPValue.Text = "HP: 20/20";
            // 
            // weapon
            // 
            weapon.AutoSize = true;
            weapon.Location = new Point(1154, 526);
            weapon.Name = "weapon";
            weapon.Size = new Size(107, 20);
            weapon.TabIndex = 3;
            weapon.Text = "Weapon: None";
            weapon.Click += weapon_Click;
            // 
            // weapons
            // 
            weapons.FormattingEnabled = true;
            weapons.Items.AddRange(new object[] { "None", "Sword", "Spear", "Bow" });
            weapons.Location = new Point(1154, 549);
            weapons.Name = "weapons";
            weapons.Size = new Size(107, 184);
            weapons.TabIndex = 4;
            weapons.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // equip
            // 
            equip.Location = new Point(1154, 739);
            equip.Name = "equip";
            equip.Size = new Size(107, 53);
            equip.TabIndex = 5;
            equip.Text = "Equip";
            equip.UseVisualStyleBackColor = true;
            equip.Click += button1_Click;
            // 
            // consumables
            // 
            consumables.FormattingEnabled = true;
            consumables.Items.AddRange(new object[] { "HP potion", "L HP potion", "MP potion" });
            consumables.Location = new Point(1267, 549);
            consumables.Name = "consumables";
            consumables.Size = new Size(107, 184);
            consumables.TabIndex = 6;
            // 
            // consumable
            // 
            consumable.Location = new Point(1267, 739);
            consumable.Name = "consumable";
            consumable.Size = new Size(107, 53);
            consumable.TabIndex = 9;
            consumable.Text = "Use";
            consumable.UseVisualStyleBackColor = true;
            consumable.Click += consumable_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1267, 526);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 10;
            label2.Text = "Consumables";
            // 
            // enemyHPBar
            // 
            enemyHPBar.Location = new Point(12, 12);
            enemyHPBar.Maximum = 15;
            enemyHPBar.Name = "enemyHPBar";
            enemyHPBar.Size = new Size(433, 50);
            enemyHPBar.TabIndex = 11;
            enemyHPBar.Value = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 12;
            label3.Text = "Enemy";
            // 
            // enemyHPValue
            // 
            enemyHPValue.AutoSize = true;
            enemyHPValue.Location = new Point(12, 85);
            enemyHPValue.Name = "enemyHPValue";
            enemyHPValue.Size = new Size(73, 20);
            enemyHPValue.TabIndex = 13;
            enemyHPValue.Text = "HP: 15/15";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1764, 693);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 14;
            label5.Text = "You";
            // 
            // attacks
            // 
            attacks.FormattingEnabled = true;
            attacks.Items.AddRange(new object[] { "Fireball", "Lightning bolt", "Weapon attack", "Ice shard", "Wind blade" });
            attacks.Location = new Point(896, 549);
            attacks.Name = "attacks";
            attacks.Size = new Size(252, 184);
            attacks.TabIndex = 15;
            // 
            // attackButton
            // 
            attackButton.Location = new Point(896, 739);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(252, 53);
            attackButton.TabIndex = 16;
            attackButton.Text = "Attack";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += button1_Click_1;
            // 
            // Log
            // 
            Log.FormattingEnabled = true;
            Log.Location = new Point(12, 117);
            Log.Name = "Log";
            Log.Size = new Size(433, 664);
            Log.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1809, 801);
            Controls.Add(Log);
            Controls.Add(attackButton);
            Controls.Add(attacks);
            Controls.Add(label5);
            Controls.Add(enemyHPValue);
            Controls.Add(label3);
            Controls.Add(enemyHPBar);
            Controls.Add(label2);
            Controls.Add(consumable);
            Controls.Add(consumables);
            Controls.Add(equip);
            Controls.Add(weapons);
            Controls.Add(weapon);
            Controls.Add(characterHPValue);
            Controls.Add(characterHPBar);
            Name = "Form2";
            Text = "Character";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar characterHPBar;
        private Label characterHPValue;
        private Label weapon;
        private ListBox weapons;
        private Button equip;
        private ListBox consumables;
        private Button consumable;
        private Label label2;
        private ProgressBar enemyHPBar;
        private Label label3;
        private Label enemyHPValue;
        private Label label5;
        private ListBox attacks;
        private Button attackButton;
        private ListBox Log;
    }
}