using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Repository;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class ClientRepository : AsyncRepository<ClientEntity>, IClientRepository
    {
        private readonly BaseContext<ClientEntity> _context;

        public ClientRepository(BaseContext<ClientEntity> context)
        {
            _context = context;
        }


    }
}
