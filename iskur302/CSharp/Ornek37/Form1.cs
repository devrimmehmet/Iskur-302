using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="devrimmehmet" & textBox2.Text=="123456")
            {
                Form2 form2 = new Form2();
                form2.Show();
                
                Color[] renkler = new Color[8] { Color.Red, Color.Blue, Color.Black, Color.Brown, Color.Purple, Color.White, Color.Pink, Color.Yellow };
                Color[] renklerfb = new Color[8] { Color.Blue, Color.Yellow, Color.Blue, Color.Yellow, Color.Blue, Color.Yellow, Color.Blue, Color.Yellow };
                Random rnd = new Random();
                int dizi_elemani = rnd.Next(0, 7);
                int dizi_elemani1 = rnd.Next(0, 7);
                form2.BackColor = renkler[dizi_elemani];
              form2.panel1.BackColor=  renklerfb[dizi_elemani1];
                form2.panel4.BackColor = renklerfb[dizi_elemani];
                //form2.panel1.BackColor= renkler[dizi_elemani];
                // form2.panel2.BackColor = renkler[dizi_elemani];
            }
            else
            {
                MessageBox.Show("Düzgün ad şifre gir gardaş! ");
            }
            
            
            
            //this.Hide();   
        }
    }
}
