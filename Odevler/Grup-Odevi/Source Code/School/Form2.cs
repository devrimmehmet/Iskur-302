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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        StudentDal _studentDal = new StudentDal();
       public Student student= new Student();
      
        private void Default()
        {
           
            tB_Name.MaxLength = 30;
            tB_Surname.MaxLength = 30;
            tB_StudentNumber.MaxLength = 20;
            tB_Phone.MaxLength = 15;
            cB_State.MaxLength = 20;
            tB_PhotoURL.MaxLength = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Default();
            tB_ID.Text = student.Id.ToString();
            tB_Name.Text= student.Name.ToString();
            tB_Surname.Text= student.Surname.ToString();
            tB_StudentNumber.Text=student.StudentNumber.ToString();
            tB_Phone.Text= student.Phone.ToString();
            pB_Picture.ImageLocation = student.PhotoUrl.ToString();
            dateTimePicker1.Value=student.RegistrationDate;
            tB_PhotoURL.Text=student.PhotoUrl.ToString();
   

            cB_State.Text= student.State.ToString();
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

       
        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (tB_Phone.Text.Length != 14 || tB_Phone.Text.Substring(1, 1) == "0")
            {
                MessageBox.Show("Telefon Numaranız Eksik Veya Hatalı Lütfen Başında Sıfır \"0\" Olmadan Deneyiniz");
            }
            else
            {
                _studentDal.Update(new Student
                {
                    Id = student.Id,
                    Name = tB_Name.Text,
                    Surname = tB_Surname.Text,
                    StudentNumber = tB_StudentNumber.Text,
                    Phone = tB_Phone.Text,
                    State = cB_State.Text,
                    PhotoUrl = tB_PhotoURL.Text,
                    RegistrationDate = student.RegistrationDate,

                });
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
                Default();
                Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Öğrenciyi Silmek İstiyor Musunuz?", "Öğrenci Bilgi Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.No)
            {
              
            }
            else if (result == DialogResult.Yes)
            {
                _studentDal.Delete(student);
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
                Close();

            }

        }

    }
}
