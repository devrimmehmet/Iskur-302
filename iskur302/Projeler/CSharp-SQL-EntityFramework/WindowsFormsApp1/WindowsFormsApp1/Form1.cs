using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Deneme;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();


        }
        ProductsDal productsDal = new ProductsDal();

        private void TableRead()
        {
            dataGridView1.DataSource = productsDal.GetAll();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TableRead();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Name = textBox1.Text;
            products.UnitPrice =Convert.ToInt32( textBox2.Text);
            productsDal.Add(products);


            // YÖNTEM 2

            //productsDal.Add(new Products
            //{
            //    Name = textBox1.Text,
            //    UnitPrice = Convert.ToInt32(textBox2.Text)
            //});


            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Başarılı  Şekilde Ekleme İşlemi Yapıldı.");
            TableRead();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ID =Convert.ToInt32( textBox5.Text);
            products.Name = textBox4.Text;
            products.UnitPrice = Convert.ToInt32(textBox3.Text);
            productsDal.Update(products);
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            MessageBox.Show("Başarılı  Şekilde Güncelleme İşlemi Yapıldı.");
            TableRead();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = (dataGridView1.CurrentRow.Cells["ID"].Value).ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            textBox3.Text= dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString();
            textBox6.Text = (dataGridView1.CurrentRow.Cells["ID"].Value).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ID = Convert.ToInt32(textBox6.Text);
            productsDal.Delete(products);
            textBox6.Clear();
            MessageBox.Show("Başarılı  Şekilde Silme İşlemi Yapıldı.");
            TableRead();
        }
    }
}
