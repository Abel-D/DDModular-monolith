using Excellerent.Modular.Shared.Application.Data.Seed;

namespace Excellerent.Modular.Project.Core
{
    public class Project :BaseEntity<ProjectEntity>
    {
        public Project()
        {

        }
        public Guid ClientId
        {
            get
            {
                return _clientId;
            }
            set
            {
                _clientId = value;
            }
        }
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Description {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        private string _name;
        private string _description;
        private Guid _clientId;
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
