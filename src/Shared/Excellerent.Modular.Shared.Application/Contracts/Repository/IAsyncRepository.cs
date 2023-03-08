using Excellerent.Modular.Shared.Application.Helpers;

namespace Excellerent.Modular.Shared.Application.Contracts.Repository
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<PagedList<T>> GetAllAsync(PaginationParameters paginationParameters);
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task Delete(T t);
        Task<T> GetById(Guid id);
    }
}
