using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace WindowsFormsApp1
{

    public class ProductsDal
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Deneme;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public List<Products> GetAll()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string str = "select * from Products";
            SqlCommand cmd = new SqlCommand(str, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Products> products = new List<Products>();
            while (reader.Read())
            {
                Products pr = new Products
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToInt32(reader["UnitPrice"])
                };
                products.Add(pr);
            }
            reader.Close();
            sqlConnection.Close();
            return products;
        }
        public void Add(Products products)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand komut = new SqlCommand("Insert into Products values (@Name,@UnitPrice)", sqlConnection);
            komut.Parameters.AddWithValue("@Name", products.Name);
            komut.Parameters.AddWithValue("UnitPrice", products.UnitPrice);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Update(Products products)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand komut = new SqlCommand("Update Products set Name=@Name, UnitPrice=@UnitPrice where ID=@ID", sqlConnection);
            komut.Parameters.AddWithValue("@ID", products.ID);
            komut.Parameters.AddWithValue("@Name", products.Name);
            komut.Parameters.AddWithValue("@UnitPrice", products.UnitPrice);
            komut.ExecuteNonQuery();
            sqlConnection.Close();


        }
        public void Delete(Products products)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand komut = new SqlCommand("Delete Products where ID=@ID", sqlConnection);
            komut.Parameters.AddWithValue("@ID", products.ID);

            komut.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}