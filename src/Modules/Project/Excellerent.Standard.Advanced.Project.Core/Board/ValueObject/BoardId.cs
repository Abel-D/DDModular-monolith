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
