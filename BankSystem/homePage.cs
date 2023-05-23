namespace BankSystem
{
    public partial class homePage : Form
    {
        public static homePage instance;
        public homePage()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustSign_Log newWind = new CustSign_Log();
            newWind.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empSign_Log newWind = new empSign_Log();
            newWind.Show();
        }
    }
}