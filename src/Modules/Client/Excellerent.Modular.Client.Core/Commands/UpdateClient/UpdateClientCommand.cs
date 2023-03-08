using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.UpdateClient
{
    public record UpdateClientCommand : IRequest<Response<Guid>>
    {
        public UpdateClientCommand(UpdateClientRequest clientRequest)
        {
            this.Request = clientRequest;
        }
        public UpdateClientRequest Request { get; private set; }
    }
}
