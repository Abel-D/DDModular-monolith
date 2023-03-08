using Excellerent.Modular.Shared.Application;
using Excellerent.Modular.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Modular.Project.Core.Queries.GetProjects
{
    public record GetProjectsQuery : IRequest<Response<PagedList<Project>>>
    {
        public GetProjectsRequest Request { get; set; }
        public GetProjectsQuery(GetProjectsRequest request)
        {
            Request = request;
        }
    }
}
