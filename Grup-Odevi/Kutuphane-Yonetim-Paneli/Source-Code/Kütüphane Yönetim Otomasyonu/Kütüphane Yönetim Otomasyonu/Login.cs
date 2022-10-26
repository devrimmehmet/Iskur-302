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

namespace Kütüphane_Yönetim_Otomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection($"Data Source=.;Initial Catalog=Library;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Employees  where IdentityNumber=@user AND Password=@pass";
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand(sorgu, sqlConnection);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            sqlConnection.Open();
            dr = cmd.ExecuteReader();
      
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                this.Hide();
                MainMenu admin = new MainMenu();
                admin.ShowDialog();
                this.Close();
                goto son;
            }
            else
            {
               // MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            dr.Close();
            string sorgu2 = "SELECT * FROM Members  where IdentityNumber=@user AND Password=@pass";
            SqlCommand cmd2;
            SqlDataReader dr2;
            cmd2 = new SqlCommand(sorgu2, sqlConnection);
            cmd2.Parameters.AddWithValue("@user", textBox1.Text);
            cmd2.Parameters.AddWithValue("@pass", textBox2.Text);
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                this.Hide();
                UserMenu user = new UserMenu();
                user.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            dr2.Close();
             son:
            sqlConnection.Close();
        }
    }
}
