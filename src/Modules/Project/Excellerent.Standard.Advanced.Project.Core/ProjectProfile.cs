using AutoMapper;

namespace Excellerent.Standard.Advanced.Project.Core
{
    internal class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectEntity, Project>();
        }
    }
}
