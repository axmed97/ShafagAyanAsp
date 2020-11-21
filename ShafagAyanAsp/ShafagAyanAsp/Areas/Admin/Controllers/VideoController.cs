using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShafagAyanAsp.Data;
using ShafagAyanAsp.Models;

namespace ShafagAyanAsp.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = "Admin, Moderator")]
    public class VideoController : Controller
    {
        private readonly FrontContext _context;
        public VideoController(FrontContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? page = 1)
        {
            var skipPage = ((int)page - 1) * 4;
            var video = await _context.Videos.OrderBy(v => v.Id).Skip(skipPage).Take(4).ToListAsync();
            ViewData["allVideoCount"] = _context.Videos.ToList().Count;
            ViewData["activePage"] = page;
            return View(video);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Videos videos)
        {
            if (!ModelState.IsValid)
            {
                return View(videos);
            }
            await _context.Videos.AddAsync(videos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Videos videos = await _context.Videos.FindAsync(id);
            if (videos == null)
            {
                return NotFound();
            }
            return View(videos);
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
            Videos videos = await _context.Videos.FindAsync(id);
            if (videos == null)
            {
                return NotFound();
            }
            if (_context.Videos.ToList().Count > 1)
            {
                _context.Videos.Remove(videos);
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
            Videos videos = await _context.Videos.FindAsync(id);
            if (videos == null)
            {
                return NotFound();
            }
            return View(videos);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Videos videos)
        {
            if (!ModelState.IsValid)
            {
                return View(videos);
            }
            Videos videosdb = await _context.Videos.FindAsync(id);
            videosdb.VideoLink = videos.VideoLink;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
