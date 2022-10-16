using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Banka_Uygulamasi
{
    public partial class GirisSifreli : Form
    {
        public GirisSifreli()
        {
            InitializeComponent();
        }
        public string Banka = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (tB_KullaniciAdi.Text=="Void Bank" && tB_Sifre.Text=="1923")
            {
                if (Banka == "Ziraat")
                {
                    Ziraat ziraat = new Ziraat();
                    this.Visible = false;
                    ziraat.ShowDialog();
                    this.Visible = true;
                }
                if (Banka == "Finans")
                {
                    Finans finans = new Finans();
                    this.Visible = false;
                    finans.ShowDialog();
                    this.Visible = true;
                }
                if (Banka == "Garanti")
                {
                    Garanti garanti = new Garanti();
                    this.Visible = false;
                    garanti.ShowDialog();
                    this.Visible = true;
                }
                if (Banka == "Yapı Kredi")
                {
                    YapiKredi yapiKredi = new YapiKredi();
                    this.Visible = false;
                    yapiKredi.ShowDialog();
                    this.Visible = true;
                }
                if (Banka == "Akbank")
                {
                    Akbank akbank = new Akbank();
                    this.Visible = false;
                    akbank.ShowDialog();
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Şifre veya Şirket Adı Hatalı");
            }

        }
    }
}
