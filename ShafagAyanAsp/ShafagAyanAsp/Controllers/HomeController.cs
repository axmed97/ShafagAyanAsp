using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShafagAyanAsp.Data;
using ShafagAyanAsp.Models;
using ShafagAyanAsp.ViewModel;

namespace ShafagAyanAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FrontContext _context;

        public HomeController(ILogger<HomeController> logger, FrontContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var slider = await _context.Sliders.OrderByDescending(s => s.Id).ToListAsync();
            var image = await _context.Images.OrderByDescending(i => i.Id).Take(4).ToListAsync();
            var video = await _context.Videos.OrderByDescending(v => v.Id).Take(4).ToListAsync();
            ViewData["allImageCount"] = _context.Images.ToList().Count;
            ViewData["allVideoCount"] = _context.Videos.ToList().Count;
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                sliders = slider,
                images = image,
                videos = video
            };
            return View(homeIndexVM);
        }

        public async Task<IActionResult> SendEmail(string email, string username, string content)
        {
                var emailInfo = _context.EmailInfos.First();
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(email, username);
            mailMessage.To.Add(new MailAddress(emailInfo.Email));
            mailMessage.Subject = "Email from Website";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "This is my email: " + email + ".  My name is: " + username+ ".  My Message: " + content;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = true;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(emailInfo.Email, emailInfo.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            await smtpClient.SendMailAsync(mailMessage);
            return Ok(new
            {
                status = 200,
                data = "",
                message = "your message has been sent successfully!"
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
