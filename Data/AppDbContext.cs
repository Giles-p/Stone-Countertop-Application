using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stonecutter.Models;

namespace stonecutter.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TimeTable> TimeTables { get; set; }
    }
}
