namespace BetterCPSTest
{
    public partial class Form1 : Form
    {

        int CPS = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                CPS++;
            }
            else
            {
                ClearDisplay();
                timer1.Start();
                CPS++;
            }

            DisplayUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            button1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            button1.Enabled = true;
        }

        void DisplayUpdate()
        {
            label1.Text = CPS.ToString();
            label2.Text = (CPS / 5).ToString();
        }

        void ClearDisplay()
        {
            label1.Text = "0";
            label2.Text = "0";
            CPS = 0;
        }
    }
}