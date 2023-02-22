using Excellerent.Standard.Advanced.Shared.Application.Helpers;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public class GetClientsRequest
    {
        public PaginationParameters PaginationParams { get; set; }

        public GetClientsRequest(PaginationParameters paginationParams)
        {
            this.PaginationParams = paginationParams ?? new PaginationParameters();
        }


    }
}
