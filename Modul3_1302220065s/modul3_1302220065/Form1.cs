namespace modul3_1302220065
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b;

        int[] input;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(label1.Text);
            label1.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt16(label1.Text);
            label1.Text = Convert.ToString(a + b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            a = 0;
            b = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + button13.Text;
        }
    }
}
