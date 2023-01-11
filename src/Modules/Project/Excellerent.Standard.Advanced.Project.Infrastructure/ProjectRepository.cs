using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Entity;
using Excellerent.Standard.Advanced.Shared.Helpers;
using Excellerent.Standard.Advanced.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    internal class ProjectRepository:AsyncRepository<ProjectEntity>,IProjectRepository
    {
        public readonly ProjectContext _context;
        public ProjectRepository(ProjectContext context)
        {
            _context = context;
        }

        public Task<ProjectEntity> Add(ProjectEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<ProjectEntity> Delete(ProjectEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<ProjectEntity> Update(ProjectEntity t)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ProjectEntity>> IAsyncRepository<ProjectEntity>.GetAllAsync(PaginationParameters paginationParameters)
        {
            throw new NotImplementedException();
        }
    }
}
