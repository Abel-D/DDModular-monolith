﻿using Excellerent.Standard.Advanced.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    public record GetProjectsRequest
    {
        public PaginationParameters PaginationParameters { get; set; }
        public GetProjectsRequest(PaginationParameters pagination)
        {
            this.PaginationParameters=pagination;
        }
    }
}