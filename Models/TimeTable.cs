using System.ComponentModel.DataAnnotations;

namespace stonecutter.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        public string? ClientName { get; set; }
        [Required(ErrorMessage = "Enter your address")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Enter your phone number")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter your email")]
        public string? Email { get; set; }
        
        public string? Description {  get; set; }
        [Required(ErrorMessage = "Enter a date and time")]
        public DateTime DateTime { get; set; }
    }
}
