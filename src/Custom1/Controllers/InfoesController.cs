using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Custom1.Models;

namespace Custom1.Controllers
{
    public class InfoesController : Controller
    {
        private ApplicationDbContext _context;

        public InfoesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Infoes
        public IActionResult Index()
        {
            return View(_context.Info.ToList());
        }

        // GET: Infoes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Info info = _context.Info.Single(m => m.ID == id);
            if (info == null)
            {
                return HttpNotFound();
            }

            return View(info);
        }

        // GET: Infoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Infoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Info info)
        {
            if (ModelState.IsValid)
            {
                _context.Info.Add(info);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(info);
        }

        // GET: Infoes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Info info = _context.Info.Single(m => m.ID == id);
            if (info == null)
            {
                return HttpNotFound();
            }
            return View(info);
        }

        // POST: Infoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Info info)
        {
            if (ModelState.IsValid)
            {
                _context.Update(info);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(info);
        }

        // GET: Infoes/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Info info = _context.Info.Single(m => m.ID == id);
            if (info == null)
            {
                return HttpNotFound();
            }

            return View(info);
        }

        // POST: Infoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Info info = _context.Info.Single(m => m.ID == id);
            _context.Info.Remove(info);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
