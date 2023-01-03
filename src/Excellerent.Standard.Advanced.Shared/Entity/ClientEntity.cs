using Excellerent.Standard.Advanced.Shared.Data.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Entity
{
    public class ClientEntity : BaseAuditModel
    {
        public ClientEntity():base(){}
       
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
