﻿namespace stonecutter.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string? StoneType { get; set; }
        public int? Quantity { get; set; }
        public string? Name { get; set; }
        
        public DateTime DateTime { get; set; }
    }
}
