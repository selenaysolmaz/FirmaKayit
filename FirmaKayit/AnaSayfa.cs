using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmaKayit.Hangar;
namespace FirmaKayit
{
    public partial class AnaSayfa : Form
    {
        Formlar _f=new Formlar();
        mesajlar _m = new mesajlar();

        public static int Aktarma = -1;

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Bilgi Giris Ekranı";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Close();             //formu kapatır.
            Application.Exit(); //projeyi tamamen kapatır.
        }
        private void btnBilgiGİris_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            groupBox1.Text = "Bilgi Giris Ekranı";
            groupBox1.ForeColor = Color.Navy;
        }
        private void btnForm2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba");
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            groupBox1.Text = "Form2 Ekranı";
            groupBox1.ForeColor = Color.Green;
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            groupBox1.Text = "Form3 Ekranı";
            groupBox1.ForeColor = Color.Maroon;
        }

        private void btnfirma1_Click(object sender, EventArgs e)
        {
            _f.FrmGir();
        }
    }
}
