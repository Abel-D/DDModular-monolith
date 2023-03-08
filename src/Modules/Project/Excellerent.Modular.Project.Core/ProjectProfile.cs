using AutoMapper;
using Excellerent.Modular.Project.Core.Commands.Add_Project;

namespace Excellerent.Modular.Project.Core
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
