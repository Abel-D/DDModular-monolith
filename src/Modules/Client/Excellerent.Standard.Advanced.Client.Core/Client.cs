using Excellerent.Standard.Advanced.Shared.Data.Seed;
using Excellerent.Standard.Advanced.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core
{
    internal class Client : BaseEntity<ClientEntity>
    {
        public Guid ClientId { get;private set; }
        public string Name { get;private set; }
        public string Description { get; private set; }
        public override ClientEntity MapToModel()
        {
           ClientEntity client=new ClientEntity();
            client.Name = Name;
            client.Description = Description;
            client.ClientId = ClientId;
            return client;
        }

        public override ClientEntity MapToModel(ClientEntity t)
        {
           this.ClientId = t.ClientId;
            this.Name=t.Name;
            this.Description=t.Description;
            return t;
        }
       
    }
}
