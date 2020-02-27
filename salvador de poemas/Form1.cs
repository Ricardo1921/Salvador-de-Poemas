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
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Texto.texto;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Texto.apagar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Texto.salvar(richTextBox1.Text);
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Texto.MAIS();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Texto.MIN();
        }
    }
}
