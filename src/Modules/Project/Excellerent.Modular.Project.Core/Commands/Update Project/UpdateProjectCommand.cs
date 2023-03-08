using Excellerent.Modular.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Core.Commands.Update_Project
{
    public record UpdateProjectCommand : IRequest<Response<Guid>>
    {
        public UpdateProjectCommand(UpdateProjectRequest request)
        {
            this.Request = request;
        }
        public UpdateProjectRequest Request { get; set; }
    }
}
