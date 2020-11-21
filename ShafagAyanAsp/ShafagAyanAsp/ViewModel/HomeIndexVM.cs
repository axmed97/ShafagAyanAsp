using ShafagAyanAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShafagAyanAsp.ViewModel
{
    public class HomeIndexVM
    {
        public IEnumerable<Sliders> sliders { get; set; }
        public IEnumerable<Images> images { get; set; }
        public IEnumerable<Videos> videos { get; set; }
    }
}
