using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class EntityContext: DbContext
    {
        public EntityContext() : base(@"Data Source=.;Initial Catalog=School;Integrated Security=True")
        {
        }

       public DbSet<Student> Students { get; set; }
 
    }
}
