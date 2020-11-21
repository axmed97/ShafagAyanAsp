using System;
using System.Collections.Generic;
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
    public class ImageController : Controller
    {
        private readonly FrontContext _context;
        private readonly IWebHostEnvironment _env;
        public ImageController(FrontContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(int? page = 1)
        {
            var skipPage = ((int)page - 1) * 4;
            var image = await _context.Images.OrderBy(i => i.Id).Skip(skipPage).Take(4).ToListAsync();
            ViewData["allImageCount"] = _context.Images.ToList().Count;
            ViewData["activePage"] = page;
            return View(image);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Images images)
        {
            if (!ModelState.IsValid)
            {
                return View(images);
            }
            if (!images.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Selected image is not valid!");
                return View(images);
            }
            if (images.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please select any image!");
                return View(images);
            }
            images.Image = await images.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.Images.AddAsync(images);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Images images = await _context.Images.FindAsync(id);
            if (images == null)
            {
                return NotFound();
            }
            return View(images);
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
            Images images = await _context.Images.FindAsync(id);
            if (images == null)
            {
                return NotFound();
            }
            if (_context.Images.ToList().Count > 1)
            {
                string path = _env.WebRootPath + @"\image\" + images.Image;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Images.Remove(images);
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
            Images images = await _context.Images.FindAsync(id);
            if (images == null)
            {
                return NotFound();
            }
            return View(images);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Images images)
        {
            if (!ModelState.IsValid)
            {
                return View(images);
            }
            Images imagesdb = await _context.Images.FindAsync(id);
            if (images.Photo != null)
            {
                if (images.Photo.ContentType.Contains("image/"))
                {
                    string path = _env.WebRootPath + @"\image\" + imagesdb.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    imagesdb.Image = await images.Photo.SaveFileAsync(_env.WebRootPath);
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(images);
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
