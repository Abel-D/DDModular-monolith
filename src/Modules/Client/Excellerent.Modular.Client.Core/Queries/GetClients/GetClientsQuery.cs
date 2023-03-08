using Excellerent.Modular.Shared.Application;
using Excellerent.Modular.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Modular.Client.Core.Queries.GetClients
{
    public record GetClientsQuery : IRequest<Response<PagedList<Excellerent.Modular.Client.Core.Client>>>
    {
        public GetClientsRequest request { get; set; }
        public GetClientsQuery(GetClientsRequest getClientsRequest)
        {
            this.request = getClientsRequest;
        }
    }
}
