using Excellerent.Standard.Advanced.Project.Core.ValueObjects;
using Excellerent.Standard.Advanced.Shared.Data;
using Excellerent.Standard.Advanced.Shared.Data.Seed;
using Excellerent.Standard.Advanced.Shared.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core
{
    internal class Project : AggregateRoot<ProjectId>
    {
       
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
    }
}
