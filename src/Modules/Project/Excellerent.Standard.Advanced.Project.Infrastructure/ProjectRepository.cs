using Excellerent.Standard.Advanced.Project.Core.Contracts;

namespace Excellerent.Standard.Advanced.Project.Infrastructure
{
    internal class ProjectRepository : AsyncRepository<ProjectEntity>, IProjectRepository
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
