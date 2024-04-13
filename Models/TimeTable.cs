namespace stonecutter.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Description {  get; set; }
        public DateTime DateTime { get; set; }
    }
}
