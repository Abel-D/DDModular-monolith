﻿using Excellerent.Standard.Advanced.Shared.Application;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
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
