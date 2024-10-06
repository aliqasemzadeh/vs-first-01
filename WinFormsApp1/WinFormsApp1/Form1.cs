namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            string aString = aTextBox.Text;
            string bString = bTextBox.Text;

            int a = Convert.ToInt32(aString);
            int b = Convert.ToInt32(bString);

            int sum = a + b;

            sumTextBox.Text = sum.ToString();

        }

        private void avgButton_Click(object sender, EventArgs e)
        {
            int u1, u2, u3;
            double g1, g2, g3;

            u1 = Convert.ToInt32(u1TB.Text);
            u2 = Convert.ToInt32(u2TB.Text);
            u3 = Convert.ToInt32(u3TB.Text);

            g1 = Convert.ToDouble(g1TB.Text);
            g2 = Convert.ToDouble(g2TB.Text);
            g3 = Convert.ToDouble(g3TB.Text);

            double avg = (g1 * u1 + g2 * u2 + g3 * u3)/(u1 + u2 + u3);
            avgTB.Text = avg.ToString();
        }
    }
}