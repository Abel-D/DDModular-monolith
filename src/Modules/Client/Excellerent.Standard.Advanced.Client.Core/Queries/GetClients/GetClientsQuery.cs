
using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Helpers;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public record GetClientsQuery:IRequest<Response<PagedList<Client>>>
    {
        public GetClientsRequest request { get; set; }
        public GetClientsQuery(GetClientsRequest getClientsRequest)
        {
            this.request = getClientsRequest;
        }
    }
}
