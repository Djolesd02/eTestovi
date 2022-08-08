using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTestovi
{
    public partial class Profesor_main : Form
    {
        public Profesor_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kreiranje_testa f = new kreiranje_testa();
            f.Show();
            this.Close();
        }

        private void Profesor_main_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            profesor_log_in f = new profesor_log_in();
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profesor_view f = new Profesor_view();
            f.Show();
            this.Close();
        }
    }
}
