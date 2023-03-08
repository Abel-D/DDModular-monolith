using Excellerent.Modular.Project.Core;
using Excellerent.Modular.Project.Core.Contracts;
using Excellerent.Modular.Shared.Infrastructure.Database;
using Excellerent.Modular.Shared.Infrastructure.Repository;
using System.Runtime.Intrinsics;

namespace Excellerent.Modular.Project.Infrastructure
{
    internal class ProjectRepository : AsyncRepository<ProjectEntity>, IProjectRepository
    {
        public ProjectRepository(BaseContext context):base(context)
        {

        }
    }
}
