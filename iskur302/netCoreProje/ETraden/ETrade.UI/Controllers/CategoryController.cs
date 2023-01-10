using Microsoft.AspNetCore.Mvc;
using ETrade.Data.Models.Entites;
using ETrade.Dal.Abstract;
using ETrade.Dal.Concrete;

namespace ETrade.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryDAl categoryDAL;
        //CategoryDAL _categoryDAL = new CategoryDAL();
        public CategoryController(ICategoryDAl categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }
        public IActionResult Index()
        {
            return View(categoryDAL.GetAll());
        }
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryDAL.Add(category);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var category = categoryDAL.Get(id);
            if (id == null || category == null)
            {
                return NotFound();
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryDAL.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Details(int id)
        {
            var category = categoryDAL.Get(id);
            if (id==null||category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        public IActionResult Delete(int id)
        {
            var category = categoryDAL.Get(id);
            if (id == null || category == null)
            {
                return NotFound();
            }

            categoryDAL.Delete(id);
            //categoryDAL.Delete(category);
           return RedirectToAction("Index");
          
        }
      
    }
}
