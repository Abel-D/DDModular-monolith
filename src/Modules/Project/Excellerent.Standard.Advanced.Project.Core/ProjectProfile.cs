using AutoMapper;
using Excellerent.Standard.Advanced.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
