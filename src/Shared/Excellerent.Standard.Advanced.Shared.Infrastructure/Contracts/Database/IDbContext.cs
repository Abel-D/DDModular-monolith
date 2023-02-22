using Excellerent.Standard.Advanced.Shared.Infrastructure.Data.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Database
{
    internal interface IDbContext<T>:IDisposable
    {
       
    }
}
