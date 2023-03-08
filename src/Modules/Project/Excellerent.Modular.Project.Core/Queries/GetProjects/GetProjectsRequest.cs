using Excellerent.Modular.Shared.Application.Helpers;

namespace Excellerent.Modular.Project.Core.Queries.GetProjects
{
    public class GetProjectsRequest
    {
        public PaginationParameters PaginationParameters { get; set; } = new PaginationParameters();
        public GetProjectsRequest()
        {
        }
    }
}
