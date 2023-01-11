using Excellerent.Standard.Advanced.Shared.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    internal class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<ProjectEntity> Projects { get; set; }
    }
}
