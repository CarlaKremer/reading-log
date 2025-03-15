using Microsoft.EntityFrameworkCore;
using PinAuthApi.Models;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Auth> Auths { get; set; }
    }
}