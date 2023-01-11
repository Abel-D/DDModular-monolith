using Excellerent.Standard.Advanced.Project.Core.Board.ValueObject;
using Excellerent.Standard.Advanced.Shared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Board
{
    internal class Board:AggregateRoot<BoardId>
    {
        public int MyProperty { get; set; }
    }
}
