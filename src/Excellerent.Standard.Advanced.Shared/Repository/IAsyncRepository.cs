

using Excellerent.Standard.Advanced.Shared.Data;
using Excellerent.Standard.Advanced.Shared.Data.Seed;
using Excellerent.Standard.Advanced.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Repository
{
    public interface IAsyncRepository<T> where T : BaseAuditModel
    {
        Task<IEnumerable<T>> GetAllAsync(PaginationParameters paginationParameters);
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task<T> Delete(T t);
    }
}
