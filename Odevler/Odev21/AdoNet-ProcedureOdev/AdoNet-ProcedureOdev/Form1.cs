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

namespace AdoNet_ProcedureOdev
{
    public partial class Form1 : Form
    {
        /*
         
create proc UrunEkle
(
  @ProductName nvarchar(40),
  @UnitPrice money,
  @UnitsInStock smallint

)
as
insert into Products (ProductName,UnitPrice,UnitsInStock) values(@ProductName,@UnitPrice,@UnitsInStock)

create proc UrunGuncelle
(
  @ProductID int,
  @ProductName nvarchar(40),
  @UnitPrice money,
  @UnitsInStock smallint

)
as
update Products set ProductName=@ProductName, UnitPrice=@UnitPrice ,UnitsInStock=@UnitsInStock  where ProductID=@ProductID

create proc UrunSil
(
  @ProductID int
)
as
delete Products where ProductID=@ProductID 
        
         
         */
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        public void MISRA() 
        {
            SqlDataAdapter SDA = new SqlDataAdapter("select * from Products", sqlConnection);
            DataTable dT = new DataTable();
            sqlConnection.Open();
            SDA.Fill(dT);
            dataGridView1.DataSource = dT;
            sqlConnection.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MISRA();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = (dataGridView1.CurrentRow.Cells["ProductID"].Value).ToString() ;
            textBox2.Text = (dataGridView1.CurrentRow.Cells["ProductName"].Value).ToString();
            textBox3.Text = Convert.ToInt32((dataGridView1.CurrentRow.Cells["UnitPrice"].Value)).ToString();
            textBox4.Text = (dataGridView1.CurrentRow.Cells["UnitsInStock"].Value).ToString();
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProductName = textBox2.Text;
            decimal UnitPrice = Convert.ToDecimal(textBox3.Text);
            decimal UnitsInStock = Convert.ToDecimal(textBox4.Text);

            sqlConnection.Open();
           
            SqlCommand Ekle = new SqlCommand("UrunEkle", sqlConnection);
            Ekle.CommandType = CommandType.StoredProcedure;

            SqlParameter adi = new SqlParameter("@ProductName", SqlDbType.NVarChar, 40);
            adi.Direction = ParameterDirection.Input; 
            adi.Value = ProductName; 
            Ekle.Parameters.Add(adi);
            SqlParameter fiyati = new SqlParameter("@UnitPrice", SqlDbType.Money);
            fiyati.Direction = ParameterDirection.Input;
            fiyati.Value = UnitPrice;
            Ekle.Parameters.Add(fiyati);
            SqlParameter stok = new SqlParameter("@UnitsInStock", SqlDbType.SmallInt);
            stok.Direction = ParameterDirection.Input;
            stok.Value = UnitsInStock;
            Ekle.Parameters.Add(stok);
            Ekle.ExecuteNonQuery();
            sqlConnection.Close();
            MISRA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ProductName = textBox2.Text;
            decimal UnitPrice = Convert.ToDecimal(textBox3.Text);
            decimal UnitsInStock = Convert.ToDecimal(textBox4.Text);
            int ProductId = Convert.ToInt32(textBox1.Text);
            sqlConnection.Open();
           
            SqlCommand Ekle = new SqlCommand("UrunGuncelle", sqlConnection);
            Ekle.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@ProductId", SqlDbType.Int);
            id.Direction = ParameterDirection.Input;
            id.Value = ProductId;
            Ekle.Parameters.Add(id);
            SqlParameter adi = new SqlParameter("@ProductName", SqlDbType.NVarChar, 40);
            adi.Direction = ParameterDirection.Input;
            adi.Value = ProductName;
            Ekle.Parameters.Add(adi);
            SqlParameter fiyati = new SqlParameter("@UnitPrice", SqlDbType.Money);
            fiyati.Direction = ParameterDirection.Input;
            fiyati.Value = UnitPrice;
            Ekle.Parameters.Add(fiyati);
            SqlParameter stok = new SqlParameter("@UnitsInStock", SqlDbType.SmallInt);
            stok.Direction = ParameterDirection.Input;
            stok.Value = UnitsInStock;
            Ekle.Parameters.Add(stok);
            Ekle.ExecuteNonQuery();
            sqlConnection.Close();
            MISRA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int ProductId = Convert.ToInt32(textBox1.Text);
            sqlConnection.Open();
            SqlCommand Sil = new SqlCommand("UrunSil", sqlConnection);
            Sil.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@ProductId", SqlDbType.Int);
            id.Direction = ParameterDirection.Input;
            id.Value = ProductId;
            Sil.Parameters.Add(id);
            Sil.ExecuteNonQuery();
            sqlConnection.Close();
            MISRA();
        }
    }
}
