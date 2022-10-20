using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_2
{
    public partial class hesapMakinesi : Form
    {
        //üçlü veya 4 lü sayı olarak yapamadım 
        double sayi1, sayi2;
        string islem;
        public hesapMakinesi()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "1";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "0";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "2";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "3";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "4";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "5";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "6";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "7";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "8";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            
            lblEkran.Text += "9";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            lblEkran.Text = lblEkran.Text.Remove(lblEkran.Text.Length - 1);
            //sil tuşuna basınca en sonunda hata vermemesi için lblekrana 0 yazdı.
            if(lblEkran.Text=="")
            {
                lblEkran.Text = " ";
            }
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        public void Topla()
        {
            
        }

        private void Btnartı_Click(object sender, EventArgs e)
        {

            //sayi1 double olduğu için double a çevirdi.
            try
            {

                sayi1 = Convert.ToDouble(lblEkran.Text);
                islem = "+";
                lblhafiza.Text = lblEkran.Text + "+";
                lblEkran.Text = "";
               // Topla();
                //islem = "+";
                ////lblhafızadaki değere yazsın lblekrandaki değeri + koyarak.
                //lblhafiza.Text = lblEkran.Text + "+";
                //lblEkran.Text = "";
                //lblEkran.Text = null;
            }
            catch (Exception)
            {

            }
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
            //işlemin ne olduğunu yazıyor.

        }

        private void Btnesittir_Click(object sender, EventArgs e)
        {
            try
            {
                sayi2 = Convert.ToDouble(lblEkran.Text);
            }
            catch (Exception)
            {

                
            }
            //İYİ GECELER
           


            if (islem=="+")
            {
                try
                {
                    lblEkran.Text = Convert.ToString(sayi1 + sayi2);
                    lblhafiza.Text = "";
                }
                catch (Exception)
                {

                }
                
            }
            if (islem == "-")
            {
                lblEkran.Text = Convert.ToString(sayi1 - sayi2);
                lblhafiza.Text = "";
            }
            if (islem == "*")
            {
                lblEkran.Text = Convert.ToString(sayi1 * sayi2);
                lblhafiza.Text = "";
            }
            if (islem == "/")
            {
                lblEkran.Text = Convert.ToString(sayi1 / sayi2);
                lblhafiza.Text = "";
            }
           
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
            //Btnesittir_Click(btnesittir, new EventArgs());
            //lblhafiza.Text = lblEkran.Text;
            //tB_GizliSonuc.Text = lblhafiza.Text;
            //lblhafiza.Text = "";
            //lblEkran.Text = "";
            //tB_GizliSonuc.Visible = true;

        }

        private void Btneksi_Click(object sender, EventArgs e)
        {
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "-";
            //lblhafızadaki değere yazsın lblekrandaki değeri - koyarak.
            lblhafiza.Text = lblEkran.Text + "-";
            //eksiye basınca labelhafızaya yazdırdığı için ekranı boş bırakıyor sayı ekranda kalmıyor 
            lblEkran.Text = "";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btncarpi_Click(object sender, EventArgs e)
        {
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "*";
            //lblhafızadaki değere yazsın lblekrandaki değeri * koyarak.
            lblhafiza.Text = lblEkran.Text + "*";
            lblEkran.Text = "";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void Btnbolü_Click(object sender, EventArgs e)
        {
            //sayi1 double olduğu için double a çevirdi.
            sayi1 = Convert.ToDouble(lblEkran.Text);
            //işlemin ne olduğunu yazıyor.
            islem = "/";
            //lblhafızadaki değere yazsın lblekrandaki değeri * koyarak.
            lblhafiza.Text = lblEkran.Text + "/";
            lblEkran.Text = "";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);

        }

        private void Btnvirgul_Click(object sender, EventArgs e)
        {
            //contains içermek demek
            //virgüle basınca virgül içermiyorsa virgün yazsın
            if (!lblEkran.Text.Contains(","))
            {
                lblEkran.Text += ",";
            }
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }

        private void LblEkran_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesi_Load(object sender, EventArgs e)
        {
            lblEkran.Select();

            //while (true)
            //{

            //}
        }

        private void lblEkran_KeyPress(object sender, KeyPressEventArgs e)
        {
            Salih(e);
        }

        private void hesapMakinesi_KeyUp(object sender, KeyEventArgs a)
        {
           
           
        }
      
  
        public void hesapMakinesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Salih(e);


        }
        public void Salih(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 8 && e.KeyChar != 13)
            {

            }
            else
            {
                tB_GizliSonuc.Visible = false;
                //tB_GizliSonuc.Text = "";

                if (e.KeyChar == '0')
                {
                    Btn0_Click(btn0, new EventArgs());
                    tB_GizliSonuc.Text = "0";
                }
                if (e.KeyChar == '1')
                {
                    Btn1_Click(btn1, new EventArgs());
                    tB_GizliSonuc.Text = "1";
                }
                if (e.KeyChar == '2')
                {
                    Btn2_Click(btn2, new EventArgs());
                    tB_GizliSonuc.Text = "2";
                }
                if (e.KeyChar == '3')
                {
                    Btn3_Click(btn3, new EventArgs());
                    tB_GizliSonuc.Text = "3";
                }
                if (e.KeyChar == '4')
                {
                    Btn4_Click(btn4, new EventArgs());
                    tB_GizliSonuc.Text = "4";
                }
                if (e.KeyChar == '5')
                {
                    Btn5_Click(btn5, new EventArgs());
                    tB_GizliSonuc.Text = "5";
                }
                if (e.KeyChar == '6')
                {
                    Btn6_Click(btn6, new EventArgs());
                    tB_GizliSonuc.Text = "6";
                }
                if (e.KeyChar == '7')
                {
                    Btn7_Click(btn7, new EventArgs());
                    tB_GizliSonuc.Text = "7";
                }
                if (e.KeyChar == '8')
                {
                    Btn8_Click(btn8, new EventArgs());
                    tB_GizliSonuc.Text = "8";
                }
                if (e.KeyChar == '9')
                {
                    Btn9_Click(btn9, new EventArgs());
                    tB_GizliSonuc.Text = "9";
                }
                if (e.KeyChar == ',')
                {
                    Btnvirgul_Click(btnvirgul, new EventArgs());
                    tB_GizliSonuc.Text += ",";
                }
                if (e.KeyChar == '+')
                {
                    Btnartı_Click(btnartı, new EventArgs());
                    lblhafiza.Text += lblEkran.Text;
                    tB_GizliSonuc.Visible = true;
                    islem = "+";


                }
                if (e.KeyChar == '-')
                {
                    Btneksi_Click(btneksi, new EventArgs());
                    lblhafiza.Text += lblEkran.Text;
                    tB_GizliSonuc.Visible = true;
                }
                if (e.KeyChar == '*')
                {
                    Btncarpi_Click(btncarpi, new EventArgs());
                    lblhafiza.Text += lblEkran.Text;
                    tB_GizliSonuc.Visible = true;
                }
                if (e.KeyChar == '/')
                {
                    Btnbolü_Click(btnbolü, new EventArgs());
                    lblhafiza.Text += lblEkran.Text;
                    tB_GizliSonuc.Visible = true;
                }
                if (e.KeyChar == 13) //enter
                {
                    Btnesittir_Click(btnesittir, new EventArgs());
                    lblhafiza.Text = lblEkran.Text;
                    tB_GizliSonuc.Text = lblhafiza.Text;
                    lblhafiza.Text = "";
                    lblEkran.Text = "";
                    tB_GizliSonuc.Visible = true;
                }
                if (e.KeyChar == 8) //backspace
                {
                    BtnSil_Click(btnSil, new EventArgs());
                    lblhafiza.Text += lblEkran.Text;
                    tB_GizliSonuc.Visible = true;
                }

            }
        }
        private void btnTemizle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Salih(e);
            

        }

        private void btnesittir_KeyPress(object sender, KeyPressEventArgs e)
        {
            Salih(e);
        }

        private void btnartı_KeyPress(object sender, KeyPressEventArgs e)
        {
            Salih(e);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "";
            tB_GizliSonuc.Text = "";
            lblhafiza.Text = "";
            btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }
    }
}
