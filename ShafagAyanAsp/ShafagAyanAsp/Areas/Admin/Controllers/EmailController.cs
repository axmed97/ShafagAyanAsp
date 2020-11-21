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
    public class EmailController : Controller
    {
        private readonly FrontContext _context;
        public EmailController(FrontContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var emailInfo = await _context.EmailInfos.ToListAsync();
            return View(emailInfo);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var emailInfo = await _context.EmailInfos.FindAsync(id);
            if (emailInfo == null)
            {
                return NotFound();
            }
            return View(emailInfo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id, EmailInfo emailInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(emailInfo);
            }
            EmailInfo emailInfodb = await _context.EmailInfos.FindAsync(id);
            emailInfodb.Email = emailInfo.Email;
            emailInfodb.Password = emailInfo.Password;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
