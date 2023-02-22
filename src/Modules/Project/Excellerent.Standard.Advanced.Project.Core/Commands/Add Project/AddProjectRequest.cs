using MediatR;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project
{
    internal record AddProjectRequest : IRequest<Response<Guid>>
    {
        public ProjectEntity Project { get; set; }
        public AddProjectRequest(Project project)
        {
            this.Project = Project;
        }
    }
}
