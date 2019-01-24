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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand komut, komut2;
        string[] anlamlar = new string[10];
        string[] kelimeler = new string[10];
        int sayac1, sayac2, sayac3, sayac4, sayac5, sayac6, sayac7, sayac8, sayac9, sayac10;
        private void Guncelle()
        {
            Random rnd = new Random();

            int[] index = new int[10];
            sayac1 = 0; sayac2 = 0; sayac3 = 0; sayac4 = 0; sayac5 = 0; sayac6 = 0; sayac7 = 0; sayac8 = 0; sayac9 = 0; sayac10 = 0;

            for (int i = 0; i < 10; i++)
            {
                index[i] = rnd.Next(0, 20000);
                conn = new SqlConnection("Server = YASEMINGOKTAS; Database = Redhouse; Trusted_Connection = true;");
                conn.Open();
                komut = new SqlCommand("Select kelimekok from soz where uid = " + index[i] + "", conn);
                komut2 = new SqlCommand("Select anlamb from soz where uid = " + index[i] + "", conn);
                kelimeler[i] = komut.ExecuteScalar().ToString();
                anlamlar[i] = komut2.ExecuteScalar().ToString();
            }
            button1.Text = kelimeler[0]; button1.BackColor = Color.RosyBrown;
            button2.Text = kelimeler[1]; button2.BackColor = Color.RosyBrown;
            button3.Text = kelimeler[2]; button3.BackColor = Color.RosyBrown;
            button4.Text = kelimeler[3]; button4.BackColor = Color.RosyBrown;
            button5.Text = kelimeler[4]; button5.BackColor = Color.RosyBrown;
            button6.Text = kelimeler[5]; button6.BackColor = Color.RosyBrown;
            button7.Text = kelimeler[6]; button7.BackColor = Color.RosyBrown;
            button8.Text = kelimeler[7]; button8.BackColor = Color.RosyBrown;
            button9.Text = kelimeler[8]; button9.BackColor = Color.RosyBrown;
            button10.Text = kelimeler[9]; button10.BackColor = Color.RosyBrown;
            conn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac1 % 2 == 0)
            {
                button1.Text = anlamlar[0];
                button1.BackColor = Color.SteelBlue;
            }
            else
            {
                button1.Text = kelimeler[0];
                button1.BackColor = Color.RosyBrown;
            }
            sayac1++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac2 % 2 == 0)
            {
                button2.Text = anlamlar[1];
                button2.BackColor = Color.SteelBlue;
            }
            else
            {
                button2.Text = kelimeler[1];
                button2.BackColor = Color.RosyBrown;
            }
            sayac2++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac3 % 2 == 0)
            {
                button3.Text = anlamlar[2];
                button3.BackColor = Color.SteelBlue;
            }
            else
            {
                button3.Text = kelimeler[2];
                button3.BackColor = Color.RosyBrown;
            }
            sayac3++;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac4 % 2 == 0)
            {
                button4.Text = anlamlar[3];
                button4.BackColor = Color.SteelBlue;
            }
            else
            {
                button4.Text = kelimeler[3];
                button4.BackColor = Color.RosyBrown;
            }
            sayac4++;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (sayac5 % 2 == 0)
            {
                button5.Text = anlamlar[4];
                button5.BackColor = Color.SteelBlue;
            }
            else
            {
                button5.Text = kelimeler[4];
                button5.BackColor = Color.RosyBrown;
            }
            sayac5++;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (sayac6 % 2 == 0)
            {
                button6.Text = anlamlar[5];
                button6.BackColor = Color.SteelBlue;
            }
            else
            {
                button6.Text = kelimeler[5];
                button6.BackColor = Color.RosyBrown;
            }
            sayac6++;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (sayac7 % 2 == 0)
            {
                button7.Text = anlamlar[6];
                button7.BackColor = Color.SteelBlue;
            }
            else
            {
                button7.Text = kelimeler[6];
                button7.BackColor = Color.RosyBrown;
            }
            sayac7++;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (sayac8 % 2 == 0)
            {
                button8.Text = anlamlar[7];
                button8.BackColor = Color.SteelBlue;
            }
            else
            {
                button8.Text = kelimeler[7];
                button8.BackColor = Color.RosyBrown;
            }
            sayac8++;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (sayac9 % 2 == 0)
            {
                button9.Text = anlamlar[8];
                button9.BackColor = Color.SteelBlue;
            }
            else
            {
                button9.Text = kelimeler[8];
                button9.BackColor = Color.RosyBrown;
            }
            sayac9++;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (sayac10 % 2 == 0)
            {
                button10.Text = anlamlar[9];
                button10.BackColor = Color.SteelBlue;
            }
            else
            {
                button10.Text = kelimeler[9];
                button10.BackColor = Color.RosyBrown;
            }
            sayac10++;
        }
    }
}
