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
    public partial class Test : Form
    {
        OleDbConnection konekcija = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; data source = zadaci.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet set = new DataSet();
        OleDbConnection konekcija2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; data source = Poeni.mdb");
        public int id = 1;
        public int id_odg = 1;
        public int broj_pitanja;
        int[] poeni;
        int broj_poena = 0;
        public Test()
        {
            
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            panel1.AutoScroll = true; 
            Add_Button();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        
        public void Add_Button()
        {
            string strSQLID = "SELECT * FROM Pitanja";
            OleDbCommand commandID = new OleDbCommand(strSQLID, konekcija);
            try
            {



                konekcija.Open();


                using (OleDbDataReader reader = commandID.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        broj_pitanja = Int32.Parse(reader["ID"].ToString());
                    }
                    poeni = new int[broj_pitanja];
                }
                commandID.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            
            int i;
            int x = 0;
            int y = 0;
            for (id = 1; id <= broj_pitanja; id++)
            {
               
                string strSQL = "SELECT * FROM Pitanja where ID = '" +  id.ToString() + "'";
                OleDbCommand commandPitanja = new OleDbCommand(strSQL, konekcija);
                if (x!=0)
                {
                    x = x - 10;
                }
                Label labela = new Label();
                labela.Size = new Size(100, 20);
                labela.Location = new Point(x, y);
                Panel pan = new Panel();
                pan.Location = new Point(x, y + 20);
                pan.Size = new Size(200, 130);
                pan.Name = "pan" + id;
                labela.BackColor = Color.Transparent;
                panel1.Controls.Add(labela);
                panel1.Controls.Add(pan);
                try
                {



                    konekcija.Open();


                    using (OleDbDataReader reader = commandPitanja.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            labela.Text = reader["Pitanje"].ToString();
                        }

                    }
                    commandPitanja.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
                y = y + 160;
                x = x + 10;
                int x1, y1;
                x1 = 0;
                y1 = 0;
                for (i= 1; i <= 3; i++)
                {
                    string[] niz = new string[3];
                    string strSQLODG = "SELECT * FROM Odgovori where ID = '" + id_odg.ToString() + "'";
                    OleDbCommand commandOdgovori = new OleDbCommand(strSQLODG, konekcija);
                    RadioButton btn = new RadioButton();
                    btn.Size = new Size(100, 30);
                    btn.Location = new Point(x1, y1);
                    btn.Font = new Font("Arial", 8);
                    try
                    {



                        konekcija.Open();


                        using (OleDbDataReader reader = commandOdgovori.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                btn.Text = reader["Odgovor"].ToString();
                                
                                btn.Tag = reader["TacanOdgovor"].ToString();
                            }

                        }
                        commandPitanja.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        konekcija.Close();
                    }
                    btn.Name = "btn" + id + "_" + id_odg;
                    btn.BackColor = Color.Transparent;
                    btn.Click += Btn_Click;
                    btn.CheckedChanged += Tacan;
                    pan.Controls.Add(btn);
                    y1 = y1 + 40;
                    id_odg++;
                }
                
                
            }
            Button submit = new Button();
            submit.Size = new Size(60, 40);
            submit.Location = new Point(x, y);
            submit.Text = "Zavrsi";
            submit.Click += Submit_Click;
            panel1.Controls.Add(submit);

        }
        public void Tacan(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            string s = rb.Parent.Name;
            string tekst = (sender as RadioButton).Name;
            int indeks = Convert.ToInt32(s.Substring(3))-1;
            Text = indeks.ToString();
            if (rb.Checked == true) 
            {
                bool p = Convert.ToBoolean(rb.Tag);
                if (p == true)
                {
                    poeni[indeks] = 1;
                    
                }
                else
                {
                    poeni[indeks] = 0;
                }
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            int suma=0;
            for (int i = 0;i<poeni.Length;i++)
            {
                suma = suma + poeni[i];
            }
            MessageBox.Show("Kraj. Broj poena koje ste osvojili je: " +suma.ToString());
            adapter.InsertCommand = new OleDbCommand("insert into Poeni values (@Ime, @Brojpoena)", konekcija2);
           
            adapter.InsertCommand.Parameters.AddWithValue("@Brojpoena", suma.ToString());
            adapter.InsertCommand.Parameters.AddWithValue("@Ime", Ucenik_log_in.Ime);

            konekcija2.Open();
            adapter.InsertCommand.ExecuteNonQuery();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int br = 0;
            for(i=0;i<panel1.Controls.Count;i++)
            {
                if(panel1.Controls[i] is RadioButton)
                {
                    br++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ucenik_log_in f = new Ucenik_log_in();
            f.Show();
            this.Close();
        }
    }
}
