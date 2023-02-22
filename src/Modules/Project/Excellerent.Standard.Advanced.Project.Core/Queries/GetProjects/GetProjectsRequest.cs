namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    public class GetProjectsRequest
    {
        public PaginationParameters PaginationParameters { get; set; }
        public GetProjectsRequest(PaginationParameters pagination)
        {
            this.PaginationParameters = pagination ?? new PaginationParameters();
        }
    }
}
