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
    public partial class Fibonacci : Form
    {
        int a = 1, b = 0, c = 0,start,finish;
        
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (textBox1.Text == "" & textBox2.Text == "")
            {
                start = 0;
                finish = 2147483647;
                Fibonacci_Hesapla();
            } else if (textBox1.Text != "" & textBox2.Text == "")
            {
                try
                {
                    start = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Maksimum 2 147 483 647 girilebilir.");
                    textBox1.Text = "0";
                }
                
                finish = 2147483647;
                Fibonacci_Hesapla();
            }
            else if (textBox1.Text != "" & textBox2.Text != "")
            {
                try
                {
                    start = Convert.ToInt32(textBox1.Text);
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Başlangıç Kısmına Maksimum 2 147 483 647 girilebilir.");
                    textBox1.Text = "0";
                }
                try
                {
                    finish = Convert.ToInt32(textBox2.Text);
                    Fibonacci_Hesapla();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bitiş Kısmına Maksimum 2 147 483 647 girilebilir.");
                    textBox2.Text = "2147483647";
                }
               
               
            }
            else if (textBox1.Text == "" & textBox2.Text != "")
            {

                start = 0;

                try
                {
                    finish = Convert.ToInt32(textBox2.Text);
                    Fibonacci_Hesapla();
                }
                catch (Exception)
                {
                    textBox2.Text = "2147483647";
                    MessageBox.Show("Bitiş Kısmına Maksimum 2 147 483 647 girilebilir.");
                }
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void Fibonacci_Hesapla()
        {
            a = 1;
            b = 0;
            c = 0;
            for (int i = 0; i < 46; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (start<c && finish>c)
                {
                    listBox2.Items.Add(c);
                }
                
            }
        }
       
        
      
    }
}
