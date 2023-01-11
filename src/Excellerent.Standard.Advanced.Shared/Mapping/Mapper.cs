using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Mapping
{
    public static class Mapper
    {
        public static T Map<T>(object obj) where T : class, new()
        {
            var src = obj.GetType().GetProperties();
            var dest = typeof(T).GetProperties();

            var result = new T();

            foreach(var props in src)
            {
                var to=dest.FirstOrDefault(x=>x.Name==props.Name);
                if(to == null)
                {
                    continue;
                }
                var val=props.GetMethod.Invoke(obj, null);
                to.GetMethod.Invoke(result, new[]{ val});
            }
           return result;
        }
    }
}
