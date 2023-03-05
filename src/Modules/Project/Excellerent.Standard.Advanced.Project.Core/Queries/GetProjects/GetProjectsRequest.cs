using Excellerent.Standard.Advanced.Shared.Application.Helpers;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    public class GetProjectsRequest
    {
        public PaginationParameters PaginationParameters { get; set; } = new PaginationParameters();
        public GetProjectsRequest()
        {
        }
    }
}
