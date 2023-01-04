using Excellerent.Standard.Advanced.Shared.Database;
using Excellerent.Standard.Advanced.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }
        public DbSet<ClientEntity> Clients { get; set; }
    }
}
