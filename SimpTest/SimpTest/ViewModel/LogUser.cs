using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpTest.ViewModel
{
   public class LogUser
    {
        [DisplayName("Username:")]
        [Required(ErrorMessage = "Username field is required")]
        public string Username { get; set; }
        [DisplayName("Password:")]
        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail field is required")]
        public string Email { get; set; }
      
         } }

    
