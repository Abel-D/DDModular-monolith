using Excellerent.Standard.Advanced.Shared.DTO;
using Excellerent.Standard.Advanced.Shared.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    public class GetProjectsRequest
    {
        public PaginationParameters PaginationParameters { get; set; }
        public GetProjectsRequest(PaginationParameters pagination)
        {
            this.PaginationParameters=pagination??new PaginationParameters();
        }
    }
}
