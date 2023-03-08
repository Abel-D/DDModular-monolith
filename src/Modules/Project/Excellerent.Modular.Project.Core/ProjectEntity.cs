using Excellerent.Modular.Shared.Application.Data.Seed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Core
{
    public class ProjectEntity:BaseAuditModel
    {
        [ForeignKey("Clients")]
        public Guid ClientId { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Description {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        private string _name;
        private string _description;
    }
}
