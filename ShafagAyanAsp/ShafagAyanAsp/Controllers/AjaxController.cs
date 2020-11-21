using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShafagAyanAsp.Data;
using ShafagAyanAsp.ViewModel;

namespace ShafagAyanAsp.Controllers
{
    public class AjaxController : Controller
    {
        private readonly FrontContext _context;
        public AjaxController(FrontContext context)
        {
            _context = context;
        }
        public IActionResult LoadMoreImage(int skipCount)
        {
            var image = _context.Images.OrderByDescending(i => i.Id).Skip(skipCount).Take(4).ToList();
            return PartialView("_ImagePartial", new HomeIndexVM { images = image });
        }
        public IActionResult LoadMoreVideo(int skipCount)
        {
            var video = _context.Videos.OrderByDescending(i => i.Id).Skip(skipCount).Take(4).ToList();
            return PartialView("_VideoPartial", new HomeIndexVM { videos = video });
        }
    }
}
