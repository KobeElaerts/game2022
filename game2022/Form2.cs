using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace game2022
{
    public partial class Form2 : Form
    {
        private int turn = 0;
        private int indexx = 0;
        private int missingHP = 0;
        public Form2()
        {
            InitializeComponent();
            weapons.SelectedItem = "None";
            attacks.SelectedItem = "Weapon attack";
            consumables.SelectedItem = "HP potion";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            weapon.Text = "Weapon: " + weapons.SelectedItem.ToString();

        }

        private void weapon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (characterHPBar.Value == 0 || enemyHPBar.Value == 0)
            {
                Log.Items.Add("The battle is already over");
                return;
            }
            Random random = new Random();

            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kobe\\source\\repos\\game2022\\game2022\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            turn += 1;

            
            Log.Items.Add("Turn " + turn.ToString());
            indexx = attacks.SelectedIndex + 1;

            SqlCommand command = new SqlCommand("SELECT name, damage FROM dbo.Attack where id = " + indexx, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var attack = new Attack(reader.GetString(0), reader.GetInt32(1));
                if (enemyHPBar.Value < attack.Damage)
                {
                    enemyHPBar.Value = 0;
                }
                else
                {
                    enemyHPBar.Value -= attack.Damage;
                    Log.Items.Add("You used " + attack.Name);
                }
                enemyHPValue.Text = "HP: " + enemyHPBar.Value.ToString() + "/15";

                if (enemyHPBar.Value == 0)
                {
                    Log.Items.Add("You won");
                }
            }
            reader.Close();

            indexx = random.Next(1, 4);
            SqlCommand Ecommand = new SqlCommand("Select name, damage FROM dbo.EAttack where id = " + indexx, conn);
            SqlDataReader Ereader = Ecommand.ExecuteReader();
            while (Ereader.Read())
            {
                var eattack = new EAttack(Ereader.GetString(0), Ereader.GetInt32(1));
                if (characterHPBar.Value < eattack.Damage)
                {
                    characterHPBar.Value = 0;
                }
                else
                {
                    characterHPBar.Value -= eattack.Damage;
                    Log.Items.Add("The enemy used " + eattack.Name);
                }
                characterHPValue.Text = "HP: " + characterHPBar.Value.ToString() + "/20";
                if (characterHPBar.Value == 0)
                {
                    Log.Items.Add("You died");
                }

            }
            Ereader.Close();
        }

        private void consumable_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            missingHP = characterHPBar.Maximum - characterHPBar.Value;
            indexx = consumables.SelectedIndex + 1;
            turn += 1;
            Log.Items.Add("Turn " + turn.ToString());

            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Kobe\\source\\repos\\game2022\\game2022\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            SqlCommand Ccommand = new SqlCommand("Select name, healing from Consumable where id = " + indexx, conn);
            SqlDataReader Creader = Ccommand.ExecuteReader();
            while (Creader.Read())
            {
                var consumablez = new Consumable(Creader.GetString(0), Creader.GetInt32(1));

                if (characterHPBar.Value > missingHP) { characterHPBar.Value = 20; } else
                {
                    characterHPBar.Value += consumablez.Healing;
                }
                characterHPValue.Text = "HP: " + characterHPBar.Value.ToString() + "/20";
                Log.Items.Add("You used " + consumablez.Name);
                consumables.Items.Remove(consumables.SelectedItem);
            }
            Creader.Close();

            indexx = random.Next(1, 4);
            SqlCommand Ecommand = new SqlCommand("Select name, damage FROM dbo.EAttack where id = " + indexx, conn);
            SqlDataReader Ereader = Ecommand.ExecuteReader();
            while (Ereader.Read())
            {
                var eattack = new EAttack(Ereader.GetString(0), Ereader.GetInt32(1));
                if (characterHPBar.Value < eattack.Damage)
                {
                    characterHPBar.Value = 0;
                }
                else
                {
                    characterHPBar.Value -= eattack.Damage;
                    Log.Items.Add("The enemy used " + eattack.Name);
                }
                characterHPValue.Text = "HP: " + characterHPBar.Value.ToString() + "/20";
                if (characterHPBar.Value == 0)
                {
                    Log.Items.Add("You died");
                }

            }
            Ereader.Close();
        }
    }
}
