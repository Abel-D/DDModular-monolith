using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Core.Commands.Delete_Project
{
    public class DeleteProjectRequest
    {
        public DeleteProjectRequest()
        {

        }
        public Guid ProjectId { get; set; }
    }
}
