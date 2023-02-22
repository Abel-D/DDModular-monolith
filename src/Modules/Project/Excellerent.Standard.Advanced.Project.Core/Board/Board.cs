using Excellerent.Standard.Advanced.Project.Core.Board.ValueObject;

namespace Excellerent.Standard.Advanced.Project.Core.Board
{
    internal class Board : AggregateRoot<BoardId>
    {
        public int MyProperty { get; set; }
    }
}
