using Excellerent.Standard.Advanced.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.AddClient
{
    internal class AddClientRequest : Request<Client>
    {
        public AddClientRequest(Client t) : base(t)
        {
        }
    }
}
