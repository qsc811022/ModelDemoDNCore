using Microsoft.AspNetCore.Mvc;

using ModelDemoDNCore.Data;
using ModelDemoDNCore.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDemoDNCore.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList=_db.Item;
            return View(objList);
        }
        public IActionResult Create()
        {
            
            return View();
        }
    }
}
