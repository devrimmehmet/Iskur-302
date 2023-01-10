using ETrade.Business.Concrete;
using ETrade.Data.Context;
using ETrade.Data.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dal.Concrete
{
    public class OrderDAL:GenericRepositiory<Order,ETradeContext>
    {
    }
}
