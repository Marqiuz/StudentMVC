using Microsoft.EntityFrameworkCore;
using WebApplication8.Models.Entities;

namespace WebApplication8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
       
        {  
        }
        public DbSet<Student> Students { get; set; }
    }
}
