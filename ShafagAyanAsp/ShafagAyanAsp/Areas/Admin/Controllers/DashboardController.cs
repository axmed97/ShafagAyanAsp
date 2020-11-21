using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShafagAyanAsp.Data;
using ShafagAyanAsp.ViewModel;

namespace ShafagAyanAsp.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Authorize(Roles = "Admin, Moderator")]
    public class DashboardController : Controller
    {
        private readonly FrontContext _context;
        public DashboardController(FrontContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var slider = await _context.Sliders.ToListAsync();
            var image = await _context.Images.ToListAsync();
            var video = await _context.Videos.ToListAsync();
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                sliders = slider,
                images = image,
                videos = video
            };
            return View(homeIndexVM);
        }
    }
}
