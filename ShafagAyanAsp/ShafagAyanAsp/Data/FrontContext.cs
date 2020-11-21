using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShafagAyanAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShafagAyanAsp.Data
{
    public class FrontContext:IdentityDbContext<AppUser>
    {
        public FrontContext(DbContextOptions<FrontContext> options):base(options)
        {

        }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<EmailInfo> EmailInfos { get; set; }
    }
}
