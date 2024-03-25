using BaiThucHanh.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person{get; set;}
    }
}