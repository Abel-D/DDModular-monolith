using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Project.Core.Commands.Add_Project
{
    public record AddProjectCommand : IRequest<Response<Guid>>
    {
        public AddProjectRequest Request { get; set; }
        public AddProjectCommand(AddProjectRequest request)
        {
            this.Request = request;
        }
    }
}
