using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShafagAyanAsp.ViewModel
{
    public class ResetPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Passwrod { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Passwrod))]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}
