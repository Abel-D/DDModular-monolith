using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Repository;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class ClientRepository : AsyncRepository<ClientEntity>, IClientRepository
    {
        private readonly ClientContext _context;

        public ClientRepository(ClientContext context)
        {
            _context = context;
        }

       
    }
}
