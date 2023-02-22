namespace Excellerent.Standard.Advanced.Project.Core.ValueObjects
{
    internal sealed class ProjectId : IEquatable<ProjectId>
    {
        public Guid Id { get; }

        public ProjectId() : this(Guid.NewGuid())
        {

        }
        public ProjectId(Guid id)
        {
            this.Id = id;
        }
        public bool Equals(ProjectId? other)
        {
            if (ReferenceEquals(null, other)) return false;
            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ProjectId)obj);
        }
        public override int GetHashCode() => Id.GetHashCode();

        public override string ToString() => Id.ToString();

        public static implicit operator ProjectId(Guid value) => new(value);

        public static implicit operator Guid(ProjectId value) => value.Id;
    }
}
