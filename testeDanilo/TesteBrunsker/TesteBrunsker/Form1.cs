using System;
using System.Windows.Forms;

namespace TesteBrunsker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir o form2 e ocultar o form1
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //abrir o form3 e ocultar o form1
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
