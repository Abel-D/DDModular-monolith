using Excellerent.Modular.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Core.Queries.GetProjectById
{
    public record GetProjectByIdQuery : IRequest<Response<Project>>
    {
        public GetProjectByIdQuery(GetProjectByIdRequest request)
        {
            this.Request = request;
        }
        public GetProjectByIdRequest Request { get; set; }
    }
}
