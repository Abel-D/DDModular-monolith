using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Update_Project
{
    public class UpdateProjectRequest
    {
        public UpdateProjectRequest()
        {

        }
        public Guid ProjectId { get; set; }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
