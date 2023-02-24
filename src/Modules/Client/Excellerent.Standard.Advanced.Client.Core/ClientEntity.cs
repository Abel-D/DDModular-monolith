using Excellerent.Standard.Advanced.Shared.Application.Data.Seed;

namespace Excellerent.Standard.Advanced.Client.Core
{
    public class ClientEntity : BaseAuditModel
    {
        public ClientEntity()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                value = name;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            private set
            {
                value = description;
            }
        }
        public string name;
        public string description;
    }
}
