using Excellerent.Standard.Advanced.Shared.Application.Contracts.Repository;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Database;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Repository
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : class
    {
        private readonly BaseContext _context;

        public AsyncRepository(BaseContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }
      
        public async Task<T> Add(T t)
        {
            await _context.Set<T>().AddAsync(t);
            _context.SaveChanges();
            return t;
        }

        public async Task Delete(T t)
        {
           
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
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
