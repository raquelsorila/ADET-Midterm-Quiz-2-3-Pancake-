using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentRecordsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordsApp.Controllers
{
    public class GradeController : Controller
    {
        private readonly AppIdentityDbContext _context;

        public GradeController(AppIdentityDbContext context)
        {
            _context = context;
        }

        // GET: Grades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grade.ToListAsync());
        }

        // GET: Grades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // GET: Grades/Create/
        public IActionResult Create()
        {
            StudentsDropdownList();
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Prelim_Quiz1,Prelim_Quiz2,Prelim_Quiz3,Prelim_Assign1,Prelim_Assign2,Prelim_Assign3,Midterm_Quiz1,Midterm_Quiz2,Midterm_Quiz3,Midterm_Assign1,Midterm_Assign2,Midterm_Assign3,Prefinal_Quiz1,Prefinal_Quiz2,Prefinal_Quiz3,Prefinal_Assign1,Prefinal_Assign2,Prefinal_Assign3,Final_Quiz1,Final_Quiz2,Final_Quiz3,Final_Assign1,Final_Assign2,Final_Assign3,StudentID")] Grade grade)
        {
            System.Diagnostics.Debug.WriteLine(grade.StudentID);
            if (ModelState.IsValid)
            {
                _context.Add(grade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            StudentsDropdownList(grade.StudentID);
            return View(grade);
        }

        // GET: Grades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade.FindAsync(id);
            if (grade == null)
            {
                return NotFound();
            }
            StudentsDropdownList(grade.StudentID);
            return View(grade);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Prelim_Quiz1,Prelim_Quiz2,Prelim_Quiz3,Prelim_Assign1,Prelim_Assign2,Prelim_Assign3,Midterm_Quiz1,Midterm_Quiz2,Midterm_Quiz3,Midterm_Assign1,Midterm_Assign2,Midterm_Assign3,Prefinal_Quiz1,Prefinal_Quiz2,Prefinal_Quiz3,Prefinal_Assign1,Prefinal_Assign2,Prefinal_Assign3,Final_Quiz1,Final_Quiz2,Final_Quiz3,Final_Assign1,Final_Assign2,Final_Assign3,StudentID")] Grade grade)
        {
            if (id != grade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grade);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", "Student", new { id = grade.StudentID });
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradeExists(grade.Id))
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
            StudentsDropdownList(grade.StudentID);
            return View(grade);
        }

        // GET: Grades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grade = await _context.Grade.FindAsync(id);
            _context.Grade.Remove(grade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradeExists(int id)
        {
            return _context.Grade.Any(e => e.Id == id);
        }

        private void StudentsDropdownList(object selectedStudent = null)
        {
            var studentsQuery = from u in _context.Student
                                orderby u.Id
                                select u;

            ViewBag.StudentID = new SelectList(studentsQuery.AsNoTracking(), "Id", "FullName", selectedStudent);
        }
    }
}
