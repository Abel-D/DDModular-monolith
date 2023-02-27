using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient
{
    public record UpdateClientCommand:IRequest<Response<Guid>>
    {
        public UpdateClientCommand(UpdateClientRequest clientRequest)
        {
            client = new Client
            {
                Guid = clientRequest.ClientId,
                Name = clientRequest.Name,
                Description = clientRequest.Description,
            };
        }
        public Client client { get;private set; }
    }
}
