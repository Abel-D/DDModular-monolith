using Excellerent.Standard.Advanced.Project.Core.ValueObjects;
using Excellerent.Standard.Advanced.Shared.Application.Data.Seed;

namespace Excellerent.Standard.Advanced.Project.Core
{
    public class Project :BaseEntity<ProjectEntity>
    {
        public Project()
        {

        }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override ProjectEntity MapToEntity()
        {
            throw new NotImplementedException();
        }

        public override ProjectEntity MapToModel(ProjectEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
