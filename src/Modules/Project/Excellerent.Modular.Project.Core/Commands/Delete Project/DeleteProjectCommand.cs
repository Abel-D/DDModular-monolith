using Excellerent.Modular.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Core.Commands.Delete_Project
{
    public record DeleteProjectCommand : IRequest<Response<Guid>>
    {
        public DeleteProjectCommand(DeleteProjectRequest request)
        {
            this.Request = request;
        }
        public DeleteProjectRequest Request { get; set; }
    }
}
