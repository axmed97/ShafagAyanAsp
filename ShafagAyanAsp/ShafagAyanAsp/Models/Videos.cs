using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShafagAyanAsp.Models
{
    public class Videos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Youtube Video Link")]
        public string VideoLink { get; set; }
    }
}
