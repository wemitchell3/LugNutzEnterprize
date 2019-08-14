using LugNutzPremium.Data;
using LugNutzPremium.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzPremium.Controllers
{
    [Authorize]
    public class WishListsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public WishListsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: WishLists
        public async Task<IActionResult> Index()
        {
            var wishList = await _context.WishList.ToListAsync();
            foreach (var item in wishList)
            {
                var Vehicle = await _context.Vehicle.FindAsync(item.VehicleId);
                ViewBag.VehicleFullName = Vehicle.FullName;
            }

            return View(wishList);
        }

            // GET: WishLists/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishList = await _context.WishList
                .FirstOrDefaultAsync(m => m.WishListId == id);
            if (wishList == null)
            {
                return NotFound();
            }

            return View(wishList);
        }

        // GET: WishLists/Create
        public async Task<IActionResult> Create()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            WishList wishList = new WishList            {
               
                VehicleSelectList = await _context.Vehicle.Where(v => v.UserId == currentUser.Id).Select(v => new SelectListItem
                {
                    Text = v.FullName,
                    Value = v.VehicleId.ToString()
                }).ToListAsync()
            };
            return View(wishList);
        }

        // POST: WishLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("WishListId,VehicleId,WishListTitle,WishListDescription,IsComplete,CreatedDate")] WishList wishList)
        {            
            if (ModelState.IsValid)
            {
                _context.Add(wishList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wishList);
        }

        // GET: WishLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishList = await _context.WishList.FindAsync(id);
            if (wishList == null)
            {
                return NotFound();
            }

            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            {
                wishList.VehicleSelectList = await _context.Vehicle.Where(v => v.UserId == currentUser.Id).Select(v => new SelectListItem
                {
                    Text = v.FullName,
                    Value = v.VehicleId.ToString()
                }).ToListAsync();
            }
            return View(wishList);
        }

        // POST: WishLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WishListId,VehicleId,WishListTitle,WishListDescription,IsComplete,CreatedDate")] WishList wishList)
        {
            if (id != wishList.WishListId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wishList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WishListExists(wishList.WishListId))
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
            return View(wishList);
        }

        // GET: WishLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wishList = await _context.WishList
                .FirstOrDefaultAsync(m => m.WishListId == id);
            if (wishList == null)
            {
                return NotFound();
            }

            return View(wishList);
        }

        // POST: WishLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wishList = await _context.WishList.FindAsync(id);
            _context.WishList.Remove(wishList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WishListExists(int id)
        {
            return _context.WishList.Any(e => e.WishListId == id);
        }
    }
}
