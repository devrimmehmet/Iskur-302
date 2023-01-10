using ETrade.Data.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Models.ViewModels
{
    public class ListViewModels
    {

        public List<Category> Categories { get; set; }=new List<Category>(); 
        public List<Product> products { get; set; }
        public ListViewModels() { 
        products= new List<Product>();
        }
    }
}
