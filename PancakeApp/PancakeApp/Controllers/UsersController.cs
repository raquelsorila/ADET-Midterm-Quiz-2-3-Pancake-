using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PancakeApp.Data;
using PancakeApp.Models;

namespace PancakeApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly StudentRecordContext _context;

        public UsersController(StudentRecordContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.Where(a => a.Role == "2").ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(s => s.Grades)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            var model = new User();
            model.Role = "2";
            return View(model);
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,LastName,FirstName,MiddleName,Email,Password,Address,Role")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();

                var userId = user.Id;
                var grade = new Grade { 
                    Prelim_Assign1 = 0,    
                    Prelim_Assign2 = 0,    
                    Prelim_Assign3 = 0,    
                    Prelim_Quiz1 = 0,    
                    Prelim_Quiz2 = 0,    
                    Prelim_Quiz3 = 0,    
                    Midterm_Assign1 = 0,    
                    Midterm_Assign2 = 0,    
                    Midterm_Assign3 = 0,    
                    Midterm_Quiz1 = 0,    
                    Midterm_Quiz2 = 0,    
                    Midterm_Quiz3 = 0,    
                    Prefinal_Assign1 = 0,    
                    Prefinal_Assign2 = 0,    
                    Prefinal_Assign3 = 0,    
                    Prefinal_Quiz1 = 0,    
                    Prefinal_Quiz2 = 0,    
                    Prefinal_Quiz3 = 0,    
                    Final_Assign1 = 0,    
                    Final_Assign2 = 0,    
                    Final_Assign3 = 0,    
                    Final_Quiz1 = 0,    
                    Final_Quiz2 = 0,    
                    Final_Quiz3 = 0,
                    UserID = userId
                };

                _context.Add<Grade>(grade);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,LastName,FirstName,MiddleName,Email,Password,Address,Role")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
