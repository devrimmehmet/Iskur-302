using ETrade.Dal.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderDAL _OrderDAL;
        public OrderController(IOrderDAL orderDAL)
        {
            _OrderDAL = orderDAL;   
        }

        public IActionResult Index()
        {
            return View(_OrderDAL.GetAll());
        }
        public IActionResult Details(int id)
        {

            return View(_OrderDAL.Get(id));
        }
      
    }
}
