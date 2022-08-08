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
    public partial class kreiranje_testa : Form
    {
        public static string tekst_dugmeta;
        OleDbConnection konekcija = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; data source = zadaci.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();

         public int i = 1;
        public int id = 1;
        public int br_pitanja = 1;
        DataSet set = new DataSet();
        public kreiranje_testa()
        {
            InitializeComponent();
        }
        private string Tacno(RadioButton radiodugme)
        {
            if (radiodugme.Checked == true)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            tekst_dugmeta = textBox1.Text;
            try
            {
 
                adapter.InsertCommand = new OleDbCommand("insert into Pitanja values (@Pitanje, @ID)", konekcija);

                adapter.InsertCommand.Parameters.AddWithValue("@Pitanje", textBox1.Text);
                adapter.InsertCommand.Parameters.AddWithValue("@ID", i.ToString());

              
                konekcija.Open();
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
            }
            try
            {

                adapter.InsertCommand = new OleDbCommand("insert into Odgovori values (@Odgovor, @RBPitanja, @TacanOdgovor, @ID)", konekcija);

                adapter.InsertCommand.Parameters.AddWithValue("@RBPitanja", i.ToString());

                adapter.InsertCommand.Parameters.AddWithValue("@Odgovor", textBox2.Text);
                
               
             
                adapter.InsertCommand.Parameters.AddWithValue("@TacanOdgovor", Tacno(radioButton1));
             
                adapter.InsertCommand.Parameters.AddWithValue("@ID", id.ToString());
                konekcija.Open();
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
                id++;
            }
            try
            {


                adapter.InsertCommand = new OleDbCommand("insert into Odgovori values (@Odgovor, @RBPitanja, @TacanOdgovor, @ID)", konekcija);

                adapter.InsertCommand.Parameters.AddWithValue("@RBPitanja", i.ToString());
            
                adapter.InsertCommand.Parameters.AddWithValue("@Odgovor", textBox3.Text);
                
            
                
            
              
                adapter.InsertCommand.Parameters.AddWithValue("@TacanOdgovor", Tacno(radioButton2));
            
                adapter.InsertCommand.Parameters.AddWithValue("@ID", id.ToString());
                konekcija.Open();
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
                id++;
            }
            try
            {

    

                adapter.InsertCommand = new OleDbCommand("insert into Odgovori values (@Odgovor, @RBPitanja, @TacanOdgovor, @ID)", konekcija);

                adapter.InsertCommand.Parameters.AddWithValue("@RBPitanja", i.ToString());

                adapter.InsertCommand.Parameters.AddWithValue("@Odgovor", textBox4.Text);

                
    
                adapter.InsertCommand.Parameters.AddWithValue("@TacanOdgovor", Tacno(radioButton3));
                adapter.InsertCommand.Parameters.AddWithValue("@ID", id.ToString());
                konekcija.Open();
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                konekcija.Close();
                id++;
            }
           i++;
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            br_pitanja++;
            label5.Text = br_pitanja.ToString() + ". pitanje: ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kreiranje_testa_Load(object sender, EventArgs e)
        {
            label5.Text = br_pitanja.ToString() + ". pitanje: ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profesor_main f = new Profesor_main();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
