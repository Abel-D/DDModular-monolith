using Excellerent.Standard.Advanced.Client.Infrastructure;
using Excellerent.Standard.Advanced.Shared.Database;
using Excellerent.Standard.Advanced.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class ClientContext : DbContext
    {
        public ClientContext()
        {

        }
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }
        public DbSet<ClientEntity> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=3002;Server=localhost;Port=5432;Database=Client;Pooling=true;");
        }

        internal class ClientContextFactory : IDesignTimeDbContextFactory<ClientContext>
        {
            public ClientContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ClientContext>();

                return new ClientContext(optionsBuilder.Options);
            }
        }
    }
    
}
