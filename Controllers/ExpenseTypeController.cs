using Microsoft.AspNetCore.Mvc;

using ModelDemoDNCore.Data;
using ModelDemoDNCore.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDemoDNCore.Controllers
{
    public class ExpenseTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpenseType> objList = _db.ExpensesType;
            return View(objList);
            //return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseType obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpensesType.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //get Delete
        public IActionResult Delete(int? id)
        {
            if (id ==null || id==0)
            {
                return NotFound();
            }
            var obj=_db.ExpensesType.Find(id);
            if (obj==null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj=_db.ExpensesType.Find(id);
            if (obj==null)
            {
                return NotFound();
            }

                _db.ExpensesType.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

        }

        //get Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpensesType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseType obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpensesType.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
