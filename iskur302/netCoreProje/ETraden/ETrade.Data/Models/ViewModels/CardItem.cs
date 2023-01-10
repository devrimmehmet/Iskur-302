using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Data.Models.Entites;
using ETrade.Data.Models.ViewModels;

namespace ETrade.Data.Models.ViewModels
{
    public class CardItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
