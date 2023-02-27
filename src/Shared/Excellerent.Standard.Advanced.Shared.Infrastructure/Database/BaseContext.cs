using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Shared.Application.Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Database
{
    public class BaseContext : DbContext
    {
        public BaseContext()
        {

        }
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {

            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Added && e.Entity is BaseAuditModel))
            {
                var entity = item.Entity as BaseAuditModel;
                if (entity != null)
                {
                    entity.CreatedDate = DateTime.UtcNow;
                    entity.CreatedbyUserGuid = new Guid();
                    entity.IsActive = true;
                    entity.IsDeleted = false;

                }
            }
            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified && e.Entity is BaseAuditModel))
            {
                var entity = item.Entity as BaseAuditModel;
                if (entity != null)
                {
                    entity.CreatedDate = DateTime.UtcNow;
                    entity.CreatedbyUserGuid = new Guid();
                    item.Property(nameof(entity.CreatedbyUserGuid)).IsModified = false;
                    item.Property(nameof(entity.CreatedDate)).IsModified = false;
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<ClientEntity> Clients { get; set; }
    }
}
