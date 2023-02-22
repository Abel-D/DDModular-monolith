using Excellerent.Standard.Advanced.Shared.Api.DTO;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
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
