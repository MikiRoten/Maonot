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
    public class FaultFormsController : Controller
    {
        private readonly MaonotContext _context;

        public FaultFormsController(MaonotContext context)
        {
            _context = context;
        }

        // GET: FaultForms
        public async Task<IActionResult> Index()
        {
            return View(await _context.FaultForms.ToListAsync());
        }

        // GET: FaultForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faultForm = await _context.FaultForms
                .SingleOrDefaultAsync(m => m.ID == id);
            if (faultForm == null)
            {
                return NotFound();
            }

            return View(faultForm);
        }

        // GET: FaultForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FaultForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Apartment,RoomNum,FullName,PhoneNumber,Description")] FaultForm faultForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faultForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faultForm);
        }

        // GET: FaultForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faultForm = await _context.FaultForms.SingleOrDefaultAsync(m => m.ID == id);
            if (faultForm == null)
            {
                return NotFound();
            }
            return View(faultForm);
        }

        // POST: FaultForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Apartment,RoomNum,FullName,PhoneNumber,Description")] FaultForm faultForm)
        {
            if (id != faultForm.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faultForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaultFormExists(faultForm.ID))
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
            return View(faultForm);
        }

        // GET: FaultForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faultForm = await _context.FaultForms
                .SingleOrDefaultAsync(m => m.ID == id);
            if (faultForm == null)
            {
                return NotFound();
            }

            return View(faultForm);
        }

        // POST: FaultForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faultForm = await _context.FaultForms.SingleOrDefaultAsync(m => m.ID == id);
            _context.FaultForms.Remove(faultForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaultFormExists(int id)
        {
            return _context.FaultForms.Any(e => e.ID == id);
        }
    }
}
