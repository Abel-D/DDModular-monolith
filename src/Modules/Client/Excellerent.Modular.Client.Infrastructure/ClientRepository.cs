using Excellerent.Modular.Client.Core;
using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Infrastructure.Database;
using Excellerent.Modular.Shared.Infrastructure.Repository;

namespace Excellerent.Modular.Client.Infrastructure
{
    internal class ClientRepository : AsyncRepository<ClientEntity>, IClientRepository
    {
        public ClientRepository(BaseContext context) : base(context)
        {
        }
    }
}