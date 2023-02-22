using Microsoft.EntityFrameworkCore;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Database
{
    public class BaseContext : DbContext
    {

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
        protected BaseContext(DbContextOptions options) : base(options)
        {

        }

    }
}
