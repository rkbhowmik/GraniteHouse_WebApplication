using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse_WebShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace GraniteHouse_WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        //database object gets by dependency injection
        private readonly ApplicationDbContext _db;

        // a connstructor needed for dependency injection
        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.SpecialTags.ToList());
        }
    }
}