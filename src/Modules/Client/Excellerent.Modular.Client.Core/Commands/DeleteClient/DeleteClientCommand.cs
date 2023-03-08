using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.DeleteClient
{
    public record DeleteClientCommand : IRequest<Response<Guid>>
    {
        public DeleteClientCommand(DeleteClientRequest request)
        {
            this.Request = request;
        }
        public DeleteClientRequest Request { get; set; }
    }
}
