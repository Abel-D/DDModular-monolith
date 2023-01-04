using Excellerent.Standard.Advanced.Shared.Data.Seed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Entity
{
    public class ProjectEntity : BaseAuditModel
    {
        public Guid ProjectId { get; set; }
        [ForeignKey("Clients")]
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
