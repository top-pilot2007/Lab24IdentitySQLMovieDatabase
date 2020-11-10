using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab24IdentitySQLMovieDatabase.Data;

namespace Lab24IdentitySQLMovieDatabase.Models
{
    public class CheckedOutMoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CheckedOutMoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CheckedOutMovies
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CheckedOutMovies.Include(c => c.Movie).Include(c => c.User);


            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CheckedOutMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkedOutMovies = await _context.CheckedOutMovies
                .Include(c => c.Movie)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (checkedOutMovies == null)
            {
                return NotFound();
            }

            return View(checkedOutMovies);
        }

        // GET: CheckedOutMovies/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "ID", "ID");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: CheckedOutMovies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,MovieId,DueDate")] CheckedOutMovies checkedOutMovies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(checkedOutMovies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "ID", "ID", checkedOutMovies.MovieId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", checkedOutMovies.UserId);
            return View(checkedOutMovies);
        }

        // GET: CheckedOutMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkedOutMovies = await _context.CheckedOutMovies.FindAsync(id);
            if (checkedOutMovies == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "ID", "ID", checkedOutMovies.MovieId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", checkedOutMovies.UserId);
            return View(checkedOutMovies);
        }

        // POST: CheckedOutMovies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,MovieId,DueDate")] CheckedOutMovies checkedOutMovies)
        {
            if (id != checkedOutMovies.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checkedOutMovies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CheckedOutMoviesExists(checkedOutMovies.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "ID", "ID", checkedOutMovies.MovieId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", checkedOutMovies.UserId);
            return View(checkedOutMovies);
        }

        // GET: CheckedOutMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkedOutMovies = await _context.CheckedOutMovies
                .Include(c => c.Movie)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (checkedOutMovies == null)
            {
                return NotFound();
            }

            return View(checkedOutMovies);
        }

        // POST: CheckedOutMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var checkedOutMovies = await _context.CheckedOutMovies.FindAsync(id);
            _context.CheckedOutMovies.Remove(checkedOutMovies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckedOutMoviesExists(int id)
        {
            return _context.CheckedOutMovies.Any(e => e.Id == id);
        }
    }
}
