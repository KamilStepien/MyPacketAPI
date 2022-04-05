using Microsoft.EntityFrameworkCore;
using MyPacket.Domain;

namespace MyPacket.Infrastructure
{
    public class MyPacketDbContext : DbContext
    {
        public MyPacketDbContext(DbContextOptions<MyPacketDbContext> options)
            : base(options) {}

        public DbSet<Transaction> Transactions { get; set; }


        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added|| e.State == EntityState.Modified));

            foreach(var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
