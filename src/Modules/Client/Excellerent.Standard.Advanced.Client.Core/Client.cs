using Excellerent.Standard.Advanced.Shared.Application.Data.Seed;

namespace Excellerent.Standard.Advanced.Client.Core
{
    public class Client : BaseEntity<ClientEntity>
    {
        private string _name;
        private string _description;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                value = _description;
            }
        }

        public override ClientEntity MapToEntity()
        {
            ClientEntity entity = new ClientEntity();
            entity.Guid = Guid;
            entity.Name = Name;
            entity.Description = Description;
            return entity;

        }

        public override ClientEntity MapToModel(ClientEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
