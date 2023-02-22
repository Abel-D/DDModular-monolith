namespace Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project
{
    internal class AddProjectCommand
    {
        public AddProjectRequest Request { get; set; }
        public AddProjectCommand(AddProjectRequest request)
        {
            this.Request = request;
        }
    }
}
