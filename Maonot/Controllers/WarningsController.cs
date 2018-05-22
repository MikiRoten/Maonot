﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Maonot.Data;
using Maonot.Models;

namespace Maonot.Controllers
{
    public class WarningsController : Controller
    {
        private readonly MaonotContext _context;

        public WarningsController(MaonotContext context)
        {
            _context = context;
        }

        // GET: Warnings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Warnings.ToListAsync());
        }

        // GET: Warnings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warning = await _context.Warnings
                .SingleOrDefaultAsync(m => m.WarningId == id);
            if (warning == null)
            {
                return NotFound();
            }

            return View(warning);
        }

        // GET: Warnings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Warnings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WarningId,WarningNumber,StudentId,Date")] Warning warning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(warning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warning);
        }

        // GET: Warnings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warning = await _context.Warnings.SingleOrDefaultAsync(m => m.WarningId == id);
            if (warning == null)
            {
                return NotFound();
            }
            return View(warning);
        }

        // POST: Warnings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WarningId,WarningNumber,StudentId,Date")] Warning warning)
        {
            if (id != warning.WarningId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarningExists(warning.WarningId))
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
            return View(warning);
        }

        // GET: Warnings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warning = await _context.Warnings
                .SingleOrDefaultAsync(m => m.WarningId == id);
            if (warning == null)
            {
                return NotFound();
            }

            return View(warning);
        }

        // POST: Warnings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var warning = await _context.Warnings.SingleOrDefaultAsync(m => m.WarningId == id);
            _context.Warnings.Remove(warning);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarningExists(int id)
        {
            return _context.Warnings.Any(e => e.WarningId == id);
        }
    }
}
