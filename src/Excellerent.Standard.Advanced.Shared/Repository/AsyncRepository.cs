
using Excellerent.Standard.Advanced.Shared.Data.Seed;
using Excellerent.Standard.Advanced.Shared.Database;
using Excellerent.Standard.Advanced.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Repository
{
    public class AsyncRepository<T> : IAsyncRepository<T>  where T: BaseAuditModel
    {
        private readonly BaseContext _context;

        //public AsyncRepository(BaseContext context)
        //{
        //    _context = context ?? throw new ArgumentNullException();
        //}

        public Task<T> Add(T t)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(T t)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(PaginationParameters paginationParameters)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
