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
    public partial class profesor_log_in : Form
    {
    

        public profesor_log_in()
        {
            InitializeComponent();         
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Uspesno logovanje");
            Profesor_main f = new Profesor_main();
            f.Show();
            this.Close();
            }
            else
            {
                MessageBox.Show("Neispravna lozinka ili korisnicko ime");
            }
            



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

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void profesor_log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
