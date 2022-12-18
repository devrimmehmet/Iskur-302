using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void TableReflesh()
        {
            dataGridView1.DataSource = _productDal.GetAll();

        }
        private void Default()
        {
            tB_Fiyat.Text = "";
            tB_Ad.Text = "";
            tB_Fiyat_Delete.Text = "";
            tB_Ad_Delete.Text = "";
            tB_ID_Delete.Text = "";
            tB_ID_Update.Text = "";
            tB_Ad_Update.Text = "";
            tB_Fiyat_Update.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TableReflesh();
            Default();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {

                Name = tB_Ad.Text,
                UnitPrice=Convert.ToInt32(tB_Fiyat.Text)
                
            });
            MessageBox.Show("Başarıyla Eklendi.");
            TableReflesh();
            Default();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tB_ID_Update.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tB_ID_Delete.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tB_Ad_Update.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tB_Fiyat_Update.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tB_Ad_Delete.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tB_Fiyat_Delete.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                ID=Convert.ToInt32( tB_ID_Update.Text),
                Name = tB_Ad_Update.Text,
                UnitPrice = Convert.ToInt32(tB_Fiyat_Update.Text)

            });
            MessageBox.Show("Başarıyla Güncellendi.");
            TableReflesh();
            Default();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                ID = Convert.ToInt32(tB_ID_Delete.Text)
            });
            MessageBox.Show("Başarıyla Silindi.");
            TableReflesh();
            Default();
        }
        private void Search(string letter)
        {
            // var sonuc = _productDal.GetAll().Where(x => x.Name.ToLower().Contains(letter.ToLower())).ToList();
            dataGridView1.DataSource = _productDal.Search(letter);
        }
        private void tB_Search_TextChanged(object sender, EventArgs e)
        {
          Search(tB_Search.Text);
        }
    }
}
