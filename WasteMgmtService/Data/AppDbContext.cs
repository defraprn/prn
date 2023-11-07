
using Microsoft.EntityFrameworkCore;
using WasteMgmtService.Models;

namespace WasteMgmtService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Waste> Wastes { get; set; }

    }

}
