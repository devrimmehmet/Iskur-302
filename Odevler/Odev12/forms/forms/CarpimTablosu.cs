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
    public partial class CarpimTablosu : Form
    {
        public CarpimTablosu()
        {
            InitializeComponent();
        }

       
        int kacAdet = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            kacAdet = Convert.ToInt32(comboBox1.Text);
            for (int i = 1; i <= kacAdet; i++)
            {
                ListBox listBox = new ListBox();
                listBox.Top = 0;
                listBox.Left =  ((i - 1) * 65);
                listBox.Width = 60;
                listBox.Height = 140;
                listBox.Name = "ListBox" + (i.ToString());
                panel1.Controls.Add(listBox);

                for (int j = 1; j <= 10; j++)
                {
                    listBox.Items.Add((i) + "x" + j + "=" + (j) * i);
                }

            }
            



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void CarpimTablosu1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "1";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
