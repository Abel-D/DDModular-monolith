using Excellerent.Standard.Advanced.Shared.Application.Data.Seed;

namespace Excellerent.Standard.Advanced.Client.Core
{
    public class Client : BaseEntity<ClientEntity>
    {
        public string name;
        public string description;
        private string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }
        private string Description
        {
            get
            {
                return description;
            }
            set
            {
                value = description;
            }
        }

        public override ClientEntity MapToEntity()
        {
            ClientEntity entity = new ClientEntity();
            entity.Guid = Guid;
            entity.name = Name;
            entity.description = Description;
            return entity;

        }

        public override ClientEntity MapToModel(ClientEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
