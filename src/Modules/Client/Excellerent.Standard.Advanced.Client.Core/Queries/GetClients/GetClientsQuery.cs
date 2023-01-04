
using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Entity;
using Excellerent.Standard.Advanced.Shared.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
