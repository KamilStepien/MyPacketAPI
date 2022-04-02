using Microsoft.EntityFrameworkCore;
using MyPacket.Domain;

namespace MyPacket.Infrastructure
{
    public class MyPacketDbContext : DbContext
    {
        public MyPacketDbContext(DbContextOptions<MyPacketDbContext> options)
            : base(options) {}

        public DbSet<Transaction> Transactions { get; set; }
    }
}
