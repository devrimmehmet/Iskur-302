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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

      
        public string Banka="";
        private void button1_Click(object sender, EventArgs e)
        {
            
            Giris giris = new Giris();
            giris.Banka= Banka = "Ziraat";
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }

        private void btn_Finans_Click(object sender, EventArgs e)
        {
            
            Giris giris = new Giris();
            giris.Banka = "Finans";
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }

        private void btn_YapiKredi_Click(object sender, EventArgs e)
        {
           
            Giris giris = new Giris();
            giris.Banka = "Yapı Kredi";
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }

        private void btn_Garanti_Click(object sender, EventArgs e)
        {
            
            Giris giris = new Giris();
            giris.Banka = "Garanti";
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }

        private void btn_Akbank_Click(object sender, EventArgs e)
        {
          
            Giris giris = new Giris();
            giris.Banka = "Akbank";
            this.Visible = false;
            giris.ShowDialog();
            this.Visible = true;
        }
    }
}
