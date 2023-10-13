using Microsoft.EntityFrameworkCore;
using MvcLotion.Models;

namespace MvcLotion.Data
{
    public class MvcLotionContext : DbContext
    {
        public MvcLotionContext(DbContextOptions<MvcLotionContext> options)
            : base(options)
        {
        }

        public DbSet<Lotion> Lotion { get; set; }
    }
}