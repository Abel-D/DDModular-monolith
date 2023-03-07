using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Delete_Project
{
    public class DeleteProjectRequest
    {
        public DeleteProjectRequest()
        {

        }
        public Guid ProjectId { get; set; }
    }
}
