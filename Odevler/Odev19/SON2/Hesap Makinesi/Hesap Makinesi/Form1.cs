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
        string select_Operator = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Salih(KeyPressEventArgs e)
        {

            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 8 && e.KeyChar != 13)
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
                if (e.KeyChar == '*')
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

                btn_Equal.Select();
            }
        }

        private void Click_Backspace(object sender, EventArgs e)
        {
            btn_Equal.Select();
            if (txt_Result.Text != "" || txt_Result.Text != string.Empty || txt_Result.Text != null)
            {
                if ((txt_Result.Text).Length == 1 || txt_Result.Text == "0")
                {
                    txt_Result.Text = "0";
                }
                if ((txt_Result.Text).Length > 1)
                {
                    txt_Result.Text = txt_Result.Text.Remove(txt_Result.Text.Length - 1, 1);

                }

            }
            Operator_Enabled_True();
        }

        private void Click_Number(object sender, EventArgs e)
        {

            btn_Equal.Select();

            Button btn = (Button)sender;

            if (txt_Result.Text == "0" || transactionActive == true)
            {
                txt_Result.Text = btn.Text;
            }
            else
            {
                txt_Result.Text += btn.Text;
            }
            number = Convert.ToDecimal(txt_Result.Text);
            Operator_Enabled_True();
            transactionActive = false;


        }

        private void Click_Virgule(object sender, EventArgs e)
        {
            btn_Equal.Select();
            if (transactionActive == true)
            {
                txt_Result.Text = "0,";
            }

            if (!txt_Result.Text.Contains(","))
            {
                txt_Result.Text += ",";


            }
            Operator_Enabled_True();
            transactionActive = false;
        }

        private void Click_Equal(object sender, EventArgs e)
        {
            Operator_Enabled_True();
            btn_Equal.Select();
            transactionActive = true;

            if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "+")
            {
                //   MessageBox.Show("girdim1");
                temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
            }
            if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "-")
            {
                //    MessageBox.Show("girdim2");

                temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
            }
            if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "x")
            {
                //   MessageBox.Show("girdim3");

                temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
            }
            if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "/")
            {
                //   MessageBox.Show("girdim4");

                temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
            }
            if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "=")
            {
                //           MessageBox.Show("girdim5");

                temporaryResult = result;
                lbl_Result.Text = temporaryResult.ToString() + " " + select_Operator;
            }


            //    MessageBox.Show("temporary" + temporaryResult.ToString());
            //    MessageBox.Show("operatör" + select_Operator);
            switch (select_Operator)
            {
                case "+":
                    result = temporaryResult + number;
                    lbl_Result.Text = lbl_Result.Text + " " + number + " =";
                    break;
                case "-":
                    result = temporaryResult - number;
                    lbl_Result.Text = lbl_Result.Text + " " + number + " =";
                    break;
                case "x":
                    result = temporaryResult * number;
                    lbl_Result.Text = lbl_Result.Text + " " + number + " =";
                    break;
                case "/":
                    result = temporaryResult / number;
                    lbl_Result.Text = lbl_Result.Text + " " + number + " =";
                    break;
                    // default: number = 0; break;
            }

            //         MessageBox.Show("result" + result.ToString());

            txt_Result.Text = result.ToString();

            //if (txt_Result.Text.Substring(txt_Result.Text.Length - 1, 1)==",")
            //{
            //    txt_Result.Text = txt_Result.Text.Remove(txt_Result.Text.Length - 1, 1);
            //}

            //    lbl_Result.Text = txt_Result.Text + " = ";

        }
        private void Operator_Enabled_True()
        {
            btn_Addition.Enabled = true;
            btn_Subtraction.Enabled = true;
            btn_Division.Enabled = true;
            btn_Multiplication.Enabled = true;
        }

        private void Click_Operator(object sender, EventArgs e)
        {
            btn_Equal.Select();
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                btn_Addition.Enabled = false;
                btn_Subtraction.Enabled = true;
                btn_Division.Enabled = true;
                btn_Multiplication.Enabled = true;
            }
            if (btn.Text == "-")
            {
                btn_Addition.Enabled = true;
                btn_Subtraction.Enabled = false;
                btn_Division.Enabled = true;
                btn_Multiplication.Enabled = true;
            }
            if (btn.Text == "*")
            {
                btn_Addition.Enabled = true;
                btn_Subtraction.Enabled = true;
                btn_Division.Enabled = true;
                btn_Multiplication.Enabled = false;
            }
            if (btn.Text == "/")
            {
                btn_Addition.Enabled = true;
                btn_Subtraction.Enabled = true;
                btn_Division.Enabled = false;
                btn_Multiplication.Enabled = true;
            }


            transactionActive = true;
            if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) != btn.Text)
            {
                MessageBox.Show("burda");
                Button btn1 = (Button)sender;
                if (txt_Result.Text.Substring(txt_Result.Text.Length - 1, 1) == ",")
                {
                    txt_Result.Text = txt_Result.Text.Remove(txt_Result.Text.Length - 1, 1);
                }
                select_Operator = btn1.Text;

                lbl_Result.Text = txt_Result.Text + " " + btn1.Text;
               
                // Click_Equal(btn_Equal, new EventArgs());

            }
            else
            {
                Button btn2 = (Button)sender;
                select_Operator = btn2.Text;
                if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "+")
                {
                    temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
                    number = decimal.Parse(txt_Result.Text);
                    result = number +temporaryResult;

                }
                if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "-")
                {
                    temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
                    number = decimal.Parse(txt_Result.Text);
                    result = number - temporaryResult;

                }
                if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "x")
                {
                    temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
                    number = decimal.Parse(txt_Result.Text);
                    result = number * temporaryResult;
                }
                if (lbl_Result.Text.Substring(lbl_Result.Text.Length - 1, 1) == "/")
                {
                    temporaryResult = decimal.Parse(lbl_Result.Text.Remove(lbl_Result.Text.Length - 1, 1));
                    number = decimal.Parse(txt_Result.Text);
                    result = number / temporaryResult;
                }
                switch (select_Operator)
                {
                    case "+":
                        lbl_Result.Text = result.ToString() + " +";
                        break;
                    case "-":
                        lbl_Result.Text = result.ToString() + " -";
                        break;
                    case "x":
                        lbl_Result.Text = result.ToString() + " x";
                        break;
                    case "/":
                        lbl_Result.Text = result.ToString() + " /";
                        break;
                }
                txt_Result.Text = result.ToString();
              

            }
        }

        private void Click_CE(object sender, EventArgs e)
        {
            btn_Equal.Select();
            txt_Result.Text = "0";
            Operator_Enabled_True();

        }

        private void Click_C(object sender, EventArgs e)
        {
            btn_Equal.Select();
            Operator_Enabled_True();
            txt_Result.Text = "0";
            lbl_Result.Text = " ";
            result = 0;
            number = 0;
            temporaryResult = 0;
            select_Operator = "";
       
        }

        private void KeyPress_ButtonsAndForms(object sender, KeyPressEventArgs e)
        {
            btn_Equal.Select();
            Salih(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Result.Text = " ";
            txt_Result.Text = "0";
            btn_Equal.Select();
        }


    }
}
