using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project
{
    internal record AddProjectRequest:IRequest<Response<Guid>>
    {
        public ProjectEntity Project { get; set; }
        public AddProjectRequest(Project project)
        {
            this.Project = Project;
        }
    }
}
