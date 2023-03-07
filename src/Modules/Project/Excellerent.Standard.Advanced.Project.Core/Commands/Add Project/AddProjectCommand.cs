using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project
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
