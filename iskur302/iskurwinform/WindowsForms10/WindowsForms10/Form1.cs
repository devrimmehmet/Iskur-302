using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seversin.... ! ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_adi.Text = tbt_adi.Text;
            lbl_soyadi.Text = tbt_soyadi.Text;
            button1.Text = "Canım Sıkıldı";
            checkedListBox1.Items.Add(lbl_adi.Text);
            comboBox1.Items.Add(lbl_adi.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Kastamonu");
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Yalova");
        }
    }
}
