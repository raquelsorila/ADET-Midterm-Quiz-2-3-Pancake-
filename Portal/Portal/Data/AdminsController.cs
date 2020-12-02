using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portal.Models;
using Portal.Data;

namespace Portal.Data
{
    public class AdminsController : Controller
    {
        private readonly PortalContext _context;

        public AdminsController(PortalContext context)
        {
            _context = context;
        }

        // GET: Admins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Admin.ToListAsync());
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin
                .FirstOrDefaultAsync(m => m.ID == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }


        // GET: Admins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentID,Last_Name,First_Name,Birthdate,Age,Address,Pq1,Pq2,Pq3,Pa1,Pa2,Pa3,PqAve,PaAve,Prelim,Mq1,Mq2,Mq3,Ma1,Ma2,Ma3,MqAve,MaAve,Midterm,Pfq1,Pfq2,Pfq3,Pfa1,Pfa2,Pfa3,PfqAve,PfaAve,Prefinals,Fq1,Fq2,Fq3,Fa1,Fa2,Fa3,FqAve,FaAve,Finals")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentID,Last_Name,First_Name,Birthdate,Age,Address,Pq1,Pq2,Pq3,Pa1,Pa2,Pa3,PqAve,PaAve,Prelim,Mq1,Mq2,Mq3,Ma1,Ma2,Ma3,MqAve,MaAve,Midterm,Pfq1,Pfq2,Pfq3,Pfa1,Pfa2,Pfa3,PfqAve,PfaAve,Prefinals,Fq1,Fq2,Fq3,Fa1,Fa2,Fa3,FqAve,FaAve,Finals")] Admin admin)
        {
            if (id != admin.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(admin.ID))
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
            return View(admin);
        }
        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admin
                .FirstOrDefaultAsync(m => m.ID == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.Admin.FindAsync(id);
            _context.Admin.Remove(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(int id)
        {
            return _context.Admin.Any(e => e.ID == id);
        }

     /*private SelectList CreateAdminDropdown()
        {
            var admin = _context.Admin.AsNoTracking().ToArray();

            var selectList = new SelectList(
                admin.Select(i => new SelectListItem { Text = i.Last_Name, Value = i.ID.ToString() }),
                 "Value",
                "Text");
            return selectList;
        }*/
    }
}
