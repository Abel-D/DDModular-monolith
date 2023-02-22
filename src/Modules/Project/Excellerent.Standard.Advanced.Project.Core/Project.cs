using Excellerent.Standard.Advanced.Project.Core.ValueObjects;


namespace Excellerent.Standard.Advanced.Project.Core
{
    internal class Project 
    {
        public Project()
        {

        }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
