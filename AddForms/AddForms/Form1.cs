namespace AddForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NUM1 = Convert.ToInt32(textBox1.Text);
            int NUM2 = Convert.ToInt32(textBox2.Text);
            int sum = NUM1 + NUM2;
            textBox3.Text = sum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
