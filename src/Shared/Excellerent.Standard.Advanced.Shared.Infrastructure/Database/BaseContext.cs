using Excellerent.Standard.Advanced.Client.Core;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

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
       
        public DbSet<ClientEntity> Clients { get; set; }
    }
}
