using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Database;
using Excellerent.Standard.Advanced.Shared.Entity;
using Excellerent.Standard.Advanced.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Infrastructure
{
    internal class ClientRepository : AsyncRepository<ClientEntity>,IClientRepository
    {
        private readonly ClientContext _context;

        public ClientRepository(ClientContext context)
        {
            _context = context;
        }

        public Task<ClientEntity> Add(ClientEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> Delete(ClientEntity t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClientEntity> Update(ClientEntity t)
        {
            throw new NotImplementedException();
        }
    }
}
