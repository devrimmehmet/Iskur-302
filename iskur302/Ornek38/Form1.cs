using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ornek38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Button[,] button = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 60;
                    button[i, j].Height = 60;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                   
                    this.Controls.Add(button[i, j]);
                    left += 60;
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                        button[i, j].Text = "Devrim";
                        button[i, j].ForeColor = Color.White;
                    }
                    else
                    {
                        button[i, j].BackColor = Color.White;
                        button[i, j].Text = "Mehmet";
                    }
                }
                top += 60;
                left = 0;
            }

        }

    }
}
    

