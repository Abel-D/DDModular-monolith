using Excellerent.Standard.Advanced.Shared.Application.Data.Seed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core
{
    public class ProjectEntity:BaseAuditModel
    {
        [ForeignKey("Clients")]
        public Guid ClientId {
            get
            {
                return _clientId;
            }
            private set
            {
                ClientId = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public string Description {
            get
            {
                return _description;
            }
           private set
            {
                _description = value;
            }
        }
        private Guid _clientId;
        private string _name;
        private string _description;
    }
}
