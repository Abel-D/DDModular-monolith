using Excellerent.Modular.Shared.Application.Data.Seed;

namespace Excellerent.Modular.Client.Core
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
            }
        }
        private string _name;
        private string _description;
    }
}
