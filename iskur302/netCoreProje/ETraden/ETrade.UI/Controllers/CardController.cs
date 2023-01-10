using ETrade.Dal.Abstract;
using ETrade.Data.Models.Entites;
using ETrade.Data.Models.Helpers;
using ETrade.Data.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CardController : Controller
    {
        private readonly IProductDAL _productDAL;
        private readonly IOrderDAL _OrderDAL;
        public CardController(IProductDAL productDAL, IOrderDAL orderDAL)
        {
            _productDAL = productDAL;
            _OrderDAL = orderDAL;
        }

        public IActionResult Index()
        {
            var card = SessionHelper.GetObjectFromJson<List<CardItem>>(HttpContext.Session, "card");
            if (card == null)
            {
                return View();
            }
            ViewBag.Total = card.Sum(i => i.Product.Price * i.Quantity).ToString("Fiyat");
            SessionHelper.Count = card.Count();
            return View(card);
        }
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<CardItem>>(HttpContext.Session, "card") == null)
            {
                var Card = new List<CardItem>();
                Card.Add(new CardItem { Product = _productDAL.Get(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "card", Card);

            }
            else
            {
                var card = SessionHelper.GetObjectFromJson<List<CardItem>>(HttpContext.Session, "card");
                int Index = isExist(card, id);
                if (Index < 0)
                {
                    card.Add(new CardItem { Product = _productDAL.Get(id), Quantity = 1 });
                }
                else
                {
                    card[Index].Quantity++;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "card", card);

                }

            }
            return RedirectToAction("Index");
        }

        private int isExist(List<CardItem> card, int id)
        {
            for (int i = 0; i < card.Count; i++)
            {
                if (card[i].Product.Id.Equals(id))
                {
                    return i;
                    break;
                }

            }
            return -1;
        }

        public IActionResult CheckOut()
        {
            return View(new ShippingDetailst());
        }
        [HttpPost]
        public IActionResult CheckOut(ShippingDetailst entity)
        {
            var Card = SessionHelper.GetObjectFromJson<List<CardItem>>(HttpContext.Session, "card");
            if (Card == null)
            {
                ModelState.AddModelError("UrunYok", "Sepetinizde Ürün Bulunmamaktadır.");
            }
            if (ModelState.IsValid)
            {
                SaveOrder(Card, entity);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "card", Card);
                return View("Completed");
            }

            return View(entity);
        }
        public void SaveOrder(List<CardItem> card, ShippingDetailst entity)
        {
            var order = new Order();
            order.OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString();
            order.Total = card.Sum(i => i.Product.Price * i.Quantity);
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.waiting;
            order.Username = entity.Name;
            order.AddressTitle = entity.AddressTitle;
            order.Address = entity.Address;
            order.City = entity.City;
            order.Mahalle = entity.Mahalle;
            order.PostalCode = entity.PostalCode;
            order.District = entity.District;
            order.Orderlines = new List<OrderLine>();
            foreach (var item in card)
            {
                var orderLine = new OrderLine();
                orderLine.Quantity= item.Quantity;
                orderLine.Price = item.Quantity * item.Product.Price;
                orderLine.ProductId = item.Product.Id;
                order.Orderlines.Add(orderLine);
            }
            _OrderDAL.Add(order);   
        }
    }
}
