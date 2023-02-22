﻿using Excellerent.Standard.Advanced.Shared.Application.Helpers;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Repository
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(PaginationParameters paginationParameters);
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task Delete(T t);
    }
}
