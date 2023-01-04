using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.DTO
{
    public class Request<T>
    {
        public Request(T t)
        {
            data = t;
        }
        public T data { get; set; }
    }
}
