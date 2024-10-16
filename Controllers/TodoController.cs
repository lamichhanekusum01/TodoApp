using Microsoft.AspNetCore.Mvc;
using InteractiveTodoApp.Data;
using InteractiveTodoApp.Models;

namespace InteractiveTodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.TodoItems.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                _context.TodoItems.Add(item);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            var item = _context.TodoItems.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                _context.TodoItems.Update(item);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Details(int id)
        {
            var item = _context.TodoItems.Find(id);
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = _context.TodoItems.Find(id);
            if (item != null)
            {
                _context.TodoItems.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
