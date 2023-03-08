using Excellerent.Modular.Shared.Application.Helpers;

namespace Excellerent.Modular.Client.Core.Queries.GetClients
{
    public class GetClientsRequest
    {
        public GetClientsRequest()
        {

        }
        public PaginationParameters PaginationParams { get; set; } = new PaginationParameters();
    }
}
