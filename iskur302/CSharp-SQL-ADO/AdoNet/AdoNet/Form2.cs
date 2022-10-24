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
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-BM2J5V5; Initial Catalog=Northwind; Integrated Security=true");
        private void KategoriTabloGuncelle()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Categories", sqlConnection);
            //            SqlCommand cmd = new SqlCommand("Sp_AdiGetir",baglanti);

            DataTable dt = new DataTable();
            sqlConnection.Open();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            KategoriTabloGuncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = txt_Name.Text;
            string description = txt_Description.Text;
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand($"insert into Categories(CategoryName,Description)\r\nvalues ('{adi}','{description}')");
            komut.Connection = sqlConnection;
            int eklenti = komut.ExecuteNonQuery();
            sqlConnection.Close();

            if (eklenti > 0)
            {
                MessageBox.Show("Ürün Eklendi Çalıştı");
                KategoriTabloGuncelle();
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi");
            }
            sqlConnection.Close();


            eklenti = 0;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = (dataGridView1.CurrentRow.Cells["CategoryID"].Value).ToString();
            txt_Name.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txt_Description.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32( txt_Id.Text);
            string adi = txt_Name.Text;
            string description = txt_Description.Text;
            sqlConnection.Open();
            SqlCommand komut = new SqlCommand($"update Categories set CategoryName='{adi}',Description='{description}' where CategoryID={id}  ");
            komut.Connection = sqlConnection;
            int eklenti = komut.ExecuteNonQuery();
            sqlConnection.Close();

            if (eklenti > 0)
            {
                MessageBox.Show("Ürün Eklendi Çalıştı");
                KategoriTabloGuncelle();
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi");
            }
            sqlConnection.Close();


            eklenti = 0;
        }
    }
}
