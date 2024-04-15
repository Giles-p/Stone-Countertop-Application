using Microsoft.AspNetCore.Mvc;
using stonecutter.Data;
using stonecutter.Models;

namespace stonecutter.Controllers
{
    public class InventoryController : Controller
    {
        private readonly AppDbContext _context;
        public InventoryController(AppDbContext appDbContext)
        {
            _context = appDbContext;
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
                _context.Inventories.Add(inventory);
                _context.SaveChanges();
                return RedirectToAction("ViewInventories");
            }
            else { return View(); }

        }

        [HttpGet]
        public IActionResult ViewInventories()
        {
            var list = _context.Inventories.ToList();
            return View(list);
        }
       
       
    }
}
