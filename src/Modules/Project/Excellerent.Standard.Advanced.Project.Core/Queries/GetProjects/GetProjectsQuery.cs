using Excellerent.Standard.Advanced.Shared.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    public record GetProjectsQuery:IRequest<PagedList<Project>>
    {
        public GetProjectsRequest Request { get; set; }
        public GetProjectsQuery(GetProjectsRequest request)
        {
            Request = request;
        }
    }
}
