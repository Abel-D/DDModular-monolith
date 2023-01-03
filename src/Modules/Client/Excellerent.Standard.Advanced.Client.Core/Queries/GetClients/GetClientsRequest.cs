using Excellerent.Standard.Advanced.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Queries.GetClients
{
    public class GetClientsRequest
    {
        public GetClientsRequest(PaginationParameters paginationParams)
        {
            this.PaginationParams = paginationParams ?? new PaginationParameters();
        }
        public PaginationParameters PaginationParams { get; set; }

    }
}
