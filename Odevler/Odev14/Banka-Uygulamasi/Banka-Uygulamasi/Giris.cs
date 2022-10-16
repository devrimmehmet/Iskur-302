using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulamasi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        public string Banka = "";
        private void btn_Bireysel_Click(object sender, EventArgs e)
        {
            if (Banka=="Ziraat")
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

        private void btn_Kurumsal_Click(object sender, EventArgs e)
        {
            GirisSifreli giris = new GirisSifreli();
            giris.Banka = Banka;
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
