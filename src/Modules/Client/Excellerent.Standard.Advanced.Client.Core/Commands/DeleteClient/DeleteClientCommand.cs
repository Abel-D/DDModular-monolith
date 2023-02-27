using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.DeleteClient
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
