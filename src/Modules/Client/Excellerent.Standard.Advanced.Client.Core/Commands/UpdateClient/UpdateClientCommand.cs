using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient
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
