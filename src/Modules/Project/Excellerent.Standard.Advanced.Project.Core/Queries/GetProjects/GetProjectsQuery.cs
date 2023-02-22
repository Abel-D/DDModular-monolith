using MediatR;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    public record GetProjectsQuery : IRequest<PagedList<Project>>
    {
        public GetProjectsRequest Request { get; set; }
        public GetProjectsQuery(GetProjectsRequest request)
        {
            Request = request;
        }
    }
}
