using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Shared.Data
{
    public class AggregateRoot<T> where T : class
    {
        private bool _versionIncremented;
        public T Id { get; protected set; }
        public int Version { get; protected set; } = 1;

        protected void IncrementVersion()
        {
            if (_versionIncremented)
            {
                return;
            }

            Version++;
            _versionIncremented = true;
        }
    }
}
