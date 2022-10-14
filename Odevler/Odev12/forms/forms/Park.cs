using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Park : Form
    {
        public Park()
        {
            InitializeComponent();
        }
        Double kalinanSure, saatUcreti,toplamTutar=0;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            toplamTutar = 0;
            label3.Text = "0 TL";
        }

        private void Park_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saatUcreti = 5;
            try
            {
                kalinanSure = Convert.ToInt32(comboBox1.Text);
            }
            catch (Exception)
            {

                kalinanSure = 8;
            }
            
            for (int i = 0; i < kalinanSure; i++)
            {
                saatUcreti=saatUcreti*1.2;
            }
            if (kalinanSure==8)
            {
                saatUcreti = 20;
            }
            toplamTutar += saatUcreti;
            label3.Text =Math.Round(toplamTutar,2).ToString()+ " TL";
            listBox3.Items.Add($"{listBox3.Items.Count + 1}.Araba ==> Kalınan Süre: {kalinanSure} saat Toplam Ücret: {Math.Round(saatUcreti, 2)} TL");
        }
    }
}
