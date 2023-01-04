using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    public class AddClientRequest : IRequest<Response<Guid>>
    {
        public ClientEntity Client { get; set; }
        public AddClientRequest(string name, string description) 
        {
            Client.Name=name;
            Client.Description = description;
        }
    }
}
