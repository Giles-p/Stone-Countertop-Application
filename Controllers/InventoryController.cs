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
        public IActionResult CreateTimeTable()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInvetory(TimeTable timeTable)
        {
            if (ModelState.IsValid)
            {
                _context.TimeTables.Add(timeTable);
                _context.SaveChanges();
                return RedirectToAction("ListTimeTables");
            }
            else { return View(); }

        }

        [HttpGet]
        public IActionResult ListInventories()
        {
            var list = _context.TimeTables.ToList();
            return View(list);
        }
       
       
    }
}
