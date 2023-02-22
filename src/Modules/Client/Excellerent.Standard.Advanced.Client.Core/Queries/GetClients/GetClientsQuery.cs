using Excellerent.Standard.Advanced.Shared.Api.DTO;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Query;
using MediatR;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public record GetClientsQuery : IRequest<Response<PagedList<Client>>>
    {
        public GetClientsRequest request { get; set; }
        public GetClientsQuery(GetClientsRequest getClientsRequest)
        {
            this.request = getClientsRequest;
        }
    }
}
