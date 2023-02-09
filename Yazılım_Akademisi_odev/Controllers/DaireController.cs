using Microsoft.AspNetCore.Mvc;
using Yazılım_Akademisi_odev.Data;
using Yazılım_Akademisi_odev.Models;

namespace Yazılım_Akademisi_odev.Controllers
{
    

    public class DaireController : Controller

    {
        private readonly ApplicationDbContext _db;
        public DaireController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Daire> objCategoryList = _db.Daireler.ToList();

            return View(objCategoryList);
            
        }


        //GET
        public IActionResult Create()
        {

            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Daire obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("CustomError", "İsimler Aynı");
            //}
            if (ModelState.IsValid)
            {
                _db.Daireler.Add(obj);
                _db.SaveChanges();
                TempData["Success"] = "Category Yaratıldı";

                return RedirectToAction("Index");
            }

            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Daireler.Find(id);
            //var categoryFromDbFirst=_db.Categories.FirstOrDefault(u=>u.Id==id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Daire obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("CustomError", "İsimler Aynı");
            //}
            if (ModelState.IsValid)
            {
                _db.Daireler.Update(obj);
                _db.SaveChanges();
                TempData["Success"] = "Category Güncellendi";
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Daireler.Find(id);
            //var categoryFromDbFirst=_db.Categories.FirstOrDefault(u=>u.Id==id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Daireler.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Daireler.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "Category Silindi";
            return RedirectToAction("Index");


        }



    }
}
