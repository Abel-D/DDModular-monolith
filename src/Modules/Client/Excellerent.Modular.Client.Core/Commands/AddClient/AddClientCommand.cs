using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.AddClient
{
    public record AddClientCommand : IRequest<Response<Guid>>
    {
        public AddClientRequest Request { get; set; }
        public AddClientCommand(AddClientRequest request)
        {
            this.Request = request;
        }
    }
}
