using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace eTestovi
{
    public partial class Ucenik_log_in : Form
    {

       public int i = 1;
   
        public Ucenik_log_in()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        public static string Ime;
        private void button1_Click(object sender, EventArgs e)
        {
            Ime = textBox1.Text;
            textBox1.Text = " ";
            Test f = new Test();
            f.Show();
            this.Close();
        }

        private void Ucenik_log_in_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
