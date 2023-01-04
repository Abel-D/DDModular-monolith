using Excellerent.Standard.Advanced.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Database
{
    public class BaseContext:DbContext
    {
       
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
        protected BaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
    }
}
