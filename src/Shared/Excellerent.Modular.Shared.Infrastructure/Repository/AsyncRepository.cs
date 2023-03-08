using Excellerent.Modular.Shared.Application.Contracts.Repository;
using Excellerent.Modular.Shared.Application.Helpers;
using Excellerent.Modular.Shared.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Excellerent.Modular.Shared.Infrastructure.Repository
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
            _context.Set<T>().AddAsync(t);
            await _context.SaveChangesAsync(CancellationToken.None);
            return t;
        }

        public async Task Delete(T t)
        {
            _context.Set<T>().Remove(t);
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<PagedList<T>> GetAllAsync(PaginationParameters paginationParameters)
        {
            return PagedList<T>.ToPagedList(_context.Set<T>().AsNoTracking().AsEnumerable(), paginationParameters.PageNumber, paginationParameters.PageSize);
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T t)
        {
            _context.Set<T>().Update(t);
            await _context.SaveChangesAsync(CancellationToken.None);
            return t;
        }
    }
}
