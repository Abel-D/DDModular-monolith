using Excellerent.Standard.Advanced.Shared.Application.Helpers;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public class GetClientsRequest
    {
        public GetClientsRequest()
        {

        }
        public PaginationParameters PaginationParams { get; set; } = new PaginationParameters();
    }
}
