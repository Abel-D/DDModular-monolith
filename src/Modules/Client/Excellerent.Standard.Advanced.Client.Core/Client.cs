using Excellerent.Standard.Advanced.Client.Core.ValueObjects;
using Excellerent.Standard.Advanced.Shared.Data;
using Excellerent.Standard.Advanced.Shared.Data.Seed;
using Excellerent.Standard.Advanced.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core
{
    internal class Client : AggregateRoot<ClientId>
    {
       // public Guid ClientId { get;private set; }
        public string Name { get;private set; }
        public string Description { get; private set; }
       
    }
}
