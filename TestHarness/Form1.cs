using System.Text;
using BenchmarkDotNet.Attributes;

namespace TestHarness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Worker.Slow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Worker.Fast();
        }
    }
}
