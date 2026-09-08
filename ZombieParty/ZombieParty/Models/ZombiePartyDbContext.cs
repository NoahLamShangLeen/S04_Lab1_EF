using Microsoft.EntityFrameworkCore;

namespace ZombieParty.Models
{
    public class ZombiePartyDbContext : DbContext
    {
        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }

    }
}
