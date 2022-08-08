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
    public partial class Profesor_view : Form
    {
        OleDbConnection konekcija = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; data source = Poeni.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet set = new DataSet();
        public Profesor_view()
        {
            InitializeComponent();
            adapter.SelectCommand = new OleDbCommand(" select * from Poeni", konekcija);
            set.Clear();
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 250;
        }

        private void Profesor_view_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profesor_main f = new Profesor_main();
            f.Show();
            this.Close();
        }
    }
}
