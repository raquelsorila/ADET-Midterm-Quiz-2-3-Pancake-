using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRecordsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordsApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppIdentityDbContext _context;

        public StudentController(AppIdentityDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        [Authorize(Roles = "Admin")]
        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentId,LastName,FirstName,MiddleName,Email,Address")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();

                var studentId = student.Id;
                var grade = new Grade
                {
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
                    StudentID = studentId
                };

                _context.Add<Grade>(grade);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [Authorize(Roles = "Admin")]
        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Student.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [Authorize(Roles = "Admin")]
        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,LastName,FirstName,MiddleName,Email,Address")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            return View(student);
        }

        [Authorize(Roles = "Admin")]
        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Student.FindAsync(id);
            _context.Student.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Grades)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Info/5
        public async Task<IActionResult> Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Grades)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
