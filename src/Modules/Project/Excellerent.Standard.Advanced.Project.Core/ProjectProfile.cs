using AutoMapper;
using Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project;

namespace Excellerent.Standard.Advanced.Project.Core
{
    internal class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectEntity, Project>();
            CreateMap<Project, ProjectEntity>();
            CreateMap<AddProjectRequest, Project>();
        }
    }
}
