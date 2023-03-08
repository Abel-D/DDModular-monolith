using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Project.Core.Commands.Add_Project
{
    public class AddProjectRequest : IRequest<Response<Guid>>
    {
        public AddProjectRequest()
        {
        }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
