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
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Fibonacci frm = new Fibonacci();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true; 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Park frm1 = new Park();
            this.Visible = false;
            frm1.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CarpimTablosu frm2 = new CarpimTablosu();
            this.Visible = false;
            frm2.ShowDialog();
            this.Visible = true;
        }
    }
   
}
