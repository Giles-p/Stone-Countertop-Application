using Microsoft.AspNetCore.Mvc;
using stonecutter.Data;
using stonecutter.Models;

namespace stonecutter.Controllers
{
    public class InventoryController : Controller
    {
        private readonly AppDbContext _context1;
        public InventoryController(AppDbContext appDbContext)
        {
            _context1 = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateInventory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInvetory(Inventory inventory)
        {
            if (ModelState.IsValid)
            {
                _context1.Inventories.Add(inventory);
                _context1.SaveChanges();
                return RedirectToAction("ViewInventory");
            }
            else { return View(); }

        }

        [HttpGet]
        public IActionResult ViewInventory()
        {
            var list = _context1.Inventories.ToList();
            return View(list);
        }
       
       
    }
}
