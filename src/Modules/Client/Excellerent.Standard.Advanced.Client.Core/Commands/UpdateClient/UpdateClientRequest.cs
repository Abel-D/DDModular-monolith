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
        [JsonConstructor]
        public UpdateClientRequest(Guid id, string name,string description)
        {
            this.ClientId = id;
            this.Name=name;
            this.Description=description;
        }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
