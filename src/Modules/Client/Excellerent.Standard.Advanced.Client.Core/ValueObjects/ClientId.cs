using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Client.Core.ValueObjects
{
    internal sealed class ClientId : IEquatable<ClientId>
    {
        public Guid Id { get; }

        public ClientId():this(Guid.NewGuid())
        {

        }
        public ClientId(Guid id)
        {
            this.Id = id;
        }
        public bool Equals(ClientId? other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ClientId)obj);
        }
        public override int GetHashCode() => Id.GetHashCode();

        public override string ToString() => Id.ToString();

        public static implicit operator ClientId(Guid value) => new(value);

        public static implicit operator Guid(ClientId value) => value.Id;
    }
}
