using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StudentDal _studentDal = new StudentDal();

        public void TableReflesh()
        {

            dataGridView1.DataSource = _studentDal.GetAll();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["PhotoUrl"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = "AD";
            dataGridView1.Columns["SurName"].HeaderText = "SOYAD";
            dataGridView1.Columns["StudentNumber"].HeaderText = "ÖĞRENCİ NUMARASI";
            dataGridView1.Columns["Phone"].HeaderText = "TELEFON";
            dataGridView1.Columns["State"].HeaderText = "DURUM";
            dataGridView1.Columns["RegistrationDate"].HeaderText = "KAYIT TARİHİ";



        }
        private void Default()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            tB_Name.MaxLength = 30;
            tB_Surname.MaxLength = 30;
            tB_StudentNumber.MaxLength = 20;
            tB_Phone.MaxLength = 14;
            tB_PhotoURL.MaxLength = 200;
            tB_Name.Text = "";
            tB_Surname.Text = "";
            tB_Phone.Text = "";
            tB_StudentNumber.Text = "";
            pB_Picture.ImageLocation = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableReflesh();
            Default();

        }

        private void btn_PhotoAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            file.ShowDialog();
            string fileURL = file.FileName;
            tB_PhotoURL.Text = fileURL;
            pB_Picture.ImageLocation = fileURL;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (tB_Phone.Text.Length != 14||tB_Phone.Text.Substring(1,1)=="0")
            {
                MessageBox.Show("Telefon Numaranız Eksik Veya Hatalı Lütfen Başında Sıfır \"0\" Olmadan Deneyiniz");
            }

            else
            {
                _studentDal.Add(new Student
                {
                    Name = tB_Name.Text,
                    Surname = tB_Surname.Text,
                    StudentNumber = tB_StudentNumber.Text,
                    Phone = tB_Phone.Text,
                    PhotoUrl = tB_PhotoURL.Text,
                    State = "ÖĞRENCİ",
                    RegistrationDate = DateTime.Now,

                });
                
                TableReflesh();
                Default();
            }

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show($"{(dataGridView1.CurrentRow.Cells["Name"].Value).ToString()} {dataGridView1.CurrentRow.Cells["Surname"].Value.ToString()} İsimli Öğrenciyi Güncellemek İstiyor Musunuz?.", "Öğrenci Bilgi Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if (result == DialogResult.Yes)
            {
                
                Form2 form2 = new Form2();
                form2.student = (new Student
                {
                    Id = Convert.ToInt32((dataGridView1.CurrentRow.Cells["Id"].Value)),
                    Name = (dataGridView1.CurrentRow.Cells["Name"].Value).ToString(),
                    Surname = dataGridView1.CurrentRow.Cells["Surname"].Value.ToString(),
                    StudentNumber = dataGridView1.CurrentRow.Cells["StudentNumber"].Value.ToString(),
                    Phone = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString(),
                    State = dataGridView1.CurrentRow.Cells["State"].Value.ToString(),
                    PhotoUrl = dataGridView1.CurrentRow.Cells["PhotoUrl"].Value.ToString(),
                    RegistrationDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["RegistrationDate"].Value)
                });
             
                form2.ShowDialog();
                TableReflesh();
            }
            
        }

        private void tB_StudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
