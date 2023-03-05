using Excellerent.Standard.Advanced.Project.Core;
using Microsoft.EntityFrameworkCore;

namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    internal class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ProjectEntity> Projects { get; set; }
    }
}
