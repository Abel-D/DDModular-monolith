using Excellerent.Standard.Advanced.Project.Core;
using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Database;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Repository;
using System.Runtime.Intrinsics;

namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    internal class ProjectRepository : AsyncRepository<ProjectEntity>, IProjectRepository
    {
        public ProjectRepository(BaseContext context):base(context)
        {

        }
    }
}
