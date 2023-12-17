namespace game2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
            startText.Text = "Your goal is to defeat the enemy. \n" +
                "You can use the items given to you in your inventory. \n" +
                "Use your attacks!";
            startButton.Enabled = false;
            startButton.Text = "Started";
        }
    }
}
