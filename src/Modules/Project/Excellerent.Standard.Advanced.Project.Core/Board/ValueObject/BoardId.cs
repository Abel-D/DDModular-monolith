using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Board.ValueObject
{
    internal sealed class BoardId : IEquatable<BoardId>
    {
        public Guid Id { get; }
        public bool Equals(BoardId? other)
        {
            throw new NotImplementedException();
        }
    }
}
