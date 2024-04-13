using Microsoft.AspNetCore.Mvc;
using stonecutter.Data;
using stonecutter.Models;

namespace stonecutter.Controllers
{
    public class TimeTableController : Controller
    {
        private readonly AppDbContext _context;
        public TimeTableController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateTimeTable() {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTimeTable(TimeTable timeTable)
        {
            if(ModelState.IsValid) {
                _context.TimeTables.Add(timeTable);
                _context.SaveChanges();
                return RedirectToAction("ListTimeTables");
            }
            else { return View(); }
            
        }

        [HttpGet]
        public IActionResult ListTimeTables() {
            var list = _context.TimeTables.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult EditTimeTable()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditTimeTable(TimeTable editedTTable)
        {
            if(ModelState.IsValid)
            {
                var timeTable = _context.TimeTables.Attach(editedTTable);
                timeTable.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("ListTimeTables");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult DeleteTimeTable(int id) {
            _context.TimeTables.Remove(_context.TimeTables.Find(id));
            _context.SaveChanges();
            return RedirectToAction("ListTimeTables");
        }
    }
}
