using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public class StudentDal
    {
        public List<Student> GetAll()
        {
            using (EntityContext context = new EntityContext())
            {
            
                return context.Database.SqlQuery<Student>("select * from Students order by Id desc").ToList();
            }

        }
            
        public void Add(Student student)
        {
           
            using (EntityContext context = new EntityContext())
            {
             
                var StudentNumber = context.Students.SingleOrDefault(d => d.StudentNumber ==student.StudentNumber);
                if (StudentNumber != null)
                {
                    MessageBox.Show("Bu Öğrenci Sistemde Var");
                }
                else
                {
                    var students = context.Entry(student);
                    students.State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                    MessageBox.Show("Öğrenci Başarıyla Eklendi.");
                }
            }

        }

        public void Update(Student student)
        {
            using (EntityContext context = new EntityContext())
            {
                    var students = context.Entry(student);
                    students.State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
            }

        }
        public void Delete(Student student)
        {
            using (EntityContext context = new EntityContext())
            {
                var students = context.Entry(student);
                students.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }

        }
        public List<Student> Search(string text)
        {

            using (EntityContext context = new EntityContext())
            {
                return context.Students.Where(x => x.Name.ToLower().Contains(text.ToLower())).ToList();
            }
        }
    }
}
