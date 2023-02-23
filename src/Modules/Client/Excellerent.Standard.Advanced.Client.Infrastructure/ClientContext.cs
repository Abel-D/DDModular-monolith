using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class BaseContext<ClientEntity>
    {
        public DbSet<ClientEntity> Clients { get; set; }
      } 

        //internal class ClientContextFactory : IDesignTimeDbContextFactory<BaseContext<ClientEntity>>
        //{
        //    public BaseContext<ClientEntity> CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<BaseContext<ClientEntity>>();

        //        return new BaseContext<ClientEntity>(optionsBuilder.Options);
        //    }
        //}
    }

}
