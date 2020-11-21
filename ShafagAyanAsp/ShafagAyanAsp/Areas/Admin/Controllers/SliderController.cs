using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShafagAyanAsp.Data;
using ShafagAyanAsp.Extensions;
using ShafagAyanAsp.Models;

namespace ShafagAyanAsp.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = "Admin, Moderator")]
    public class SliderController : Controller
    {
        private readonly FrontContext _context;
        private readonly IWebHostEnvironment _env;
        public SliderController(FrontContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(int? page =1)
        {
            var skipPage = ((int)page - 1) * 4;
            var slider = await _context.Sliders.OrderBy(i => i.Id).Skip(skipPage).Take(4).ToListAsync();
            ViewData["allSlideCount"] = _context.Sliders.ToList().Count;
            ViewData["activePage"] = page;
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Sliders sliders)
        {
            if (!ModelState.IsValid)
            {
                return View(sliders);
            }
            if (!sliders.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Selected image is not valid!");
                return View(sliders);
            }
            if (sliders.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please select any image!");
                return View(sliders);
            }
            
            sliders.Image = await sliders.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.Sliders.AddAsync(sliders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Sliders sliders = await _context.Sliders.FindAsync(id);
            if (sliders == null)
            {
                return NotFound();
            }
            return View(sliders);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Sliders sliders = await _context.Sliders.FindAsync(id);
            if (sliders == null)
            {
                return NotFound();
            }
            if (_context.Sliders.ToList().Count > 1)
            {
                string path = _env.WebRootPath + @"\image\" + sliders.Image;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Sliders.Remove(sliders);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Sliders sliders = await _context.Sliders.FindAsync(id);
            if (sliders == null)
            {
                return NotFound();
            }
            return View(sliders);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Sliders sliders)
        {
            if (!ModelState.IsValid)
            {
                return View(sliders);
            }
            Sliders slidersdb = await _context.Sliders.FindAsync(id);
            if (sliders.Photo != null)
            {
                if (sliders.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + slidersdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    slidersdb.Image = await sliders.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(sliders);
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
