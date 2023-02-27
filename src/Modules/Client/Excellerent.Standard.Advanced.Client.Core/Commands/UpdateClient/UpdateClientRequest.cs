using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.Commands.UpdateClient
{
    public class UpdateClientRequest
    {
        public UpdateClientRequest()
        {

        }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
