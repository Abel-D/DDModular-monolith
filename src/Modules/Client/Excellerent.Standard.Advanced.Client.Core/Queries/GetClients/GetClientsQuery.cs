using Excellerent.Standard.Advanced.Shared.Application;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public record GetClientsQuery : IRequest<Response<Shared.Application.Helpers.IEnumerable<Excellerent.Standard.Advanced.Client.Core.Client>>>
    {
        public GetClientsRequest request { get; set; }
        public GetClientsQuery(GetClientsRequest getClientsRequest)
        {
            this.request = getClientsRequest;
        }
    }
}
