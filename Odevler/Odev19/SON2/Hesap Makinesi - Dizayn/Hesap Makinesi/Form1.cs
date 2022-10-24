using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        decimal number = 0; //girilen sayı
        decimal temporaryResult = 0; // geçici sonuç
        decimal result = 0; // sonuç
        bool transactionActive = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Salih(KeyPressEventArgs e)
        {
            
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != 'x' && e.KeyChar != '/' && e.KeyChar != 8 && e.KeyChar != 13)
            {

            }
            else
            {

                if (e.KeyChar == '0')
                {
                    Click_Number(btn_0, new EventArgs());

                }
                if (e.KeyChar == '1')
                {
                    Click_Number(btn_1, new EventArgs());

                }
                if (e.KeyChar == '2')
                {
                    Click_Number(btn_2, new EventArgs());

                }
                if (e.KeyChar == '3')
                {
                    Click_Number(btn_3, new EventArgs());

                }
                if (e.KeyChar == '4')
                {
                    Click_Number(btn_4, new EventArgs());

                }
                if (e.KeyChar == '5')
                {
                    Click_Number(btn_5, new EventArgs());

                }
                if (e.KeyChar == '6')
                {
                    Click_Number(btn_6, new EventArgs());

                }
                if (e.KeyChar == '7')
                {
                    Click_Number(btn_7, new EventArgs());

                }
                if (e.KeyChar == '8')
                {
                    Click_Number(btn_8, new EventArgs());

                }
                if (e.KeyChar == '9')
                {
                    Click_Number(btn_9, new EventArgs());

                }
                if (e.KeyChar == ',')
                {
                    Click_Virgule(btn_Virgule, new EventArgs()); // Virgül

                }
                if (e.KeyChar == '+')
                {
                    Click_Operator(btn_Addition, new EventArgs()); // Toplama

                }
                if (e.KeyChar == '-')
                {
                    Click_Operator(btn_Subtraction, new EventArgs()); // Çıkarma


                }
                if (e.KeyChar == 'x')
                {
                    Click_Operator(btn_Multiplication, new EventArgs()); // Çarpma


                }
                if (e.KeyChar == '/')
                {
                    Click_Operator(btn_Division, new EventArgs()); // Bölme

                }
                if (e.KeyChar == 13) 
                {
                    Click_Equal(btn_Equal, new EventArgs());// enter - eşittir


                }
                if (e.KeyChar == 8) 
                {
                    Click_Backspace(btn_Backspace, new EventArgs()); //backspace


                }

            }
        }

        private void Click_Backspace(object sender, EventArgs e)
        {

        }

        private void Click_Number(object sender, EventArgs e)
        {
            
        }

        private void Click_Virgule(object sender, EventArgs e)
        {

        }

        private void Click_Equal(object sender, EventArgs e)
        {

        }

        private void Click_Operator(object sender, EventArgs e)
        {

        }

        private void Click_CE(object sender, EventArgs e)
        {

        }

        private void Click_C(object sender, EventArgs e)
        {

        }
    }
}
