using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-BM2J5V5; Initial Catalog=Northwind; Integrated Security=true");
        private void TabloYenile()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from products", sqlConnection);
            DataTable dt = new DataTable();
            sqlConnection.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            TabloYenile();
         //   dataGridView1.Columns["ProductID"].Visible = false;
         //   dataGridView1.Columns[""].Visible = false;
           // dataGridView1.Columns[""].Visible = false;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            decimal fiyat = numericUpDown1.Value;
            decimal Stok = numericUpDown2.Value;
            //  SqlCommand komut = new SqlCommand;
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand($"insert into Products(ProductName,UnitPrice,UnitsInStock)\r\nvalues ('{adi}',{fiyat},{Stok})");
            komut.Connection = sqlConnection;
       //     komut.ExecuteNonQuery();
            int eklenti = komut.ExecuteNonQuery();
            sqlConnection.Close();

            if (eklenti>0)
            {
                MessageBox.Show("Ürün Eklendi Çalıştı");
                TabloYenile();
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi");
            }
            sqlConnection.Close();


            eklenti = 0;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            form2.ShowDialog();
            
            this.Close();
        }
    }
}
