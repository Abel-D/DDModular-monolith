using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Database;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Repository;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class ClientRepository : AsyncRepository<ClientEntity>, IClientRepository
    {
        public ClientRepository(BaseContext context) : base(context)
        {
        }
    }
}