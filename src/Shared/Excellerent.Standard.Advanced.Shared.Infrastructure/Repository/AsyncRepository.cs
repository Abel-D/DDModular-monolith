using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Repository;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Database;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Repository
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : class
    {
        


        //public AsyncRepository(BaseContext context)
        //{
        //    _context = context ?? throw new ArgumentNullException();
        //}
        public AsyncRepository()
        {
           
        }

        public async Task<T> Add(T t)
        {
            using var _context=new BaseContext<T>();
            await _context.Set<T>().AddAsync(t);
            _context.SaveChanges();
            return t;
        }

        public async Task Delete(T t)
        {
            using var _context = new BaseContext<T>();
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
