namespace calculators
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
        int num1, num2, result;
        string str;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);
            switch (str)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            textBox1.Text = result.ToString();
        }
    }
}
