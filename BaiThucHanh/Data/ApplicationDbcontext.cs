using Microsoft.EntityFrameworkCore;
using BaiThucHanh.Models;
namespace BaiThucHanh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :  base(options)
        {}
        public DbSet<Person> Person { get; set;}
    }
}