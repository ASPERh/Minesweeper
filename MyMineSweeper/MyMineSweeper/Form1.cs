namespace MyMineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Left = 10;
            button1.Top = 20;
            button2.Left = button1.Left+button1.Width;
            button2.Top = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
