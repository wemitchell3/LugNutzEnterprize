﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LugNutzEnterprize.Data;
using LugNutzEnterprize.Models;

namespace LugNutzEnterprize.Controllers
{
    public class MaintenanceTasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenanceTasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MaintenanceTasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.MaintenanceTask.ToListAsync());
        }

        // GET: MaintenanceTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTask = await _context.MaintenanceTask
                .FirstOrDefaultAsync(m => m.MaintenanceTaskId == id);
            if (maintenanceTask == null)
            {
                return NotFound();
            }

            return View(maintenanceTask);
        }

        // GET: MaintenanceTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaintenanceTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("MaintenanceTaskId,VehicleId,MaintenanceTaskTitle,MaintenanceTaskDescription,TaskDueAtMileage,IsComplete,CreatedDate,TargetCompleteDate")] MaintenanceTask maintenanceTask)
        {
            if (ModelState.IsValid)
            {                
                _context.Add(maintenanceTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        // GET: MaintenanceTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTask = await _context.MaintenanceTask.FindAsync(id);
            if (maintenanceTask == null)
            {
                return NotFound();
            }
            return View(maintenanceTask);
        }

        // POST: MaintenanceTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaintenanceTaskId,VehicleId,MaintenanceTaskTitle,MaintenanceTaskDescription,TaskDueAtMileage,IsComplete,DateCreated,TargetCompleteDate")] MaintenanceTask maintenanceTask)
        {
            if (id != maintenanceTask.MaintenanceTaskId)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenanceTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceTaskExists(maintenanceTask.MaintenanceTaskId))
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
            return View(maintenanceTask);
        }

        // GET: MaintenanceTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTask = await _context.MaintenanceTask
                .FirstOrDefaultAsync(m => m.MaintenanceTaskId == id);
            if (maintenanceTask == null)
            {
                return NotFound();
            }

            return View(maintenanceTask);
        }

        // POST: MaintenanceTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maintenanceTask = await _context.MaintenanceTask.FindAsync(id);
            _context.MaintenanceTask.Remove(maintenanceTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceTaskExists(int id)
        {
            return _context.MaintenanceTask.Any(e => e.MaintenanceTaskId == id);
        }
    }
}
