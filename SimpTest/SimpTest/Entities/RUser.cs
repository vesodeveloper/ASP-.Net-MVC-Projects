using System;
using System.ComponentModel.DataAnnotations;

namespace SimpTest.Entities
{
    public class RUser
    {
       [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
