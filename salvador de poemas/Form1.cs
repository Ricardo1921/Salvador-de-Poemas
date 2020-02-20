using System;
using System.Windows.Forms;
using System.IO;

namespace salvador_de_poemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RTFFile Texto = new RTFFile();
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Texto.texto;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
