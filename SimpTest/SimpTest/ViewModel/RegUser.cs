using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpTest.ViewModel
{
    public class RegUser
    {
        [DisplayName("Enter Username:")]
        [Required(ErrorMessage ="Username is required")]
        public string Username { get; set; }
        [DisplayName("Enter Password:")]
        [Required(ErrorMessage ="Password field is required")]
        public string Password { get; set; }
        [DisplayName("Enter E-mail:")]
        [Required(ErrorMessage ="E-mail field is required")]
        public string Email { get; set; }
    }
}

