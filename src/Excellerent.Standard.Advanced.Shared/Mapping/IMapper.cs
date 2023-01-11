using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Mapping
{
    public interface IMapper
    {
        T Map<T>(object obj) where T : class, new();
    }
}
