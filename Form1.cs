using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace u2_IngilizceSozlukFlashCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter adap;        
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = YASEMINGOKTAS; Database = Redhouse; Trusted_Connection = true;");
            conn.Open();
            
            adap = new SqlDataAdapter("Select uid, kelimekok, kelime, anlamb from soz1", conn);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;
           
            conn.Close();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void radioButtonTurkce_CheckedChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = YASEMINGOKTAS; Database = Redhouse; Trusted_Connection = true;");
            conn.Open();
            label1.Text = "Aranan : "; radioButtonInglizce.Text = "İngilizce Ara"; radioButtonTurkce.Text = "Türkçe Ara";
            adap = new SqlDataAdapter("Select uid,kelimekok, kelime, anlamb from soz1", conn);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;

            conn.Close();
        }

        private void radioButtonInglizce_CheckedChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server = YASEMINGOKTAS; Database = Redhouse; Trusted_Connection = true;");
            conn.Open();
            label1.Text = "Search : "; radioButtonInglizce.Text = "Search to English"; radioButtonTurkce.Text = "Search to Turkish";
            adap = new SqlDataAdapter("Select uid, kelimekok, kelime, anlamb from soz", conn);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;

            conn.Close();
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonTurkce.Checked == true)
            {
                conn = new SqlConnection("Server = YASEMINGOKTAS; Database = Redhouse; Trusted_Connection = true;");
                conn.Open();
                adap = new SqlDataAdapter("select uid,kelimekok, kelime, anlamb  from soz1 where kelimekok like '" + txtAranan.Text + "%'", conn);

                DataTable tablo = new DataTable();
                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                conn.Close();
            }
            else if (radioButtonInglizce.Checked == true)
            {
                conn = new SqlConnection("Server = YASEMINGOKTAS; Database = Redhouse; Trusted_Connection = true;");
                conn.Open();
                adap = new SqlDataAdapter("select uid, kelimekok , kelime, anlamb from soz where kelimekok like '" + txtAranan.Text + "%'", conn);

                DataTable tablo = new DataTable();
                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                conn.Close();
            }
            
        }

        private void btnFlashCard_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Türkçe Kartlar Gelsin mi?", "FLASH CARDS", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("İngilizce Kartlar Gelsin mi?", "FLASH CARDS", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
            }
            
        }
    }
}
