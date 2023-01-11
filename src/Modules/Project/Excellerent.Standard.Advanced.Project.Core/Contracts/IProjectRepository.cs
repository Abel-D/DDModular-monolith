using Excellerent.Standard.Advanced.Shared.Entity;
using Excellerent.Standard.Advanced.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Contracts
{
    public interface IProjectRepository:IAsyncRepository<ProjectEntity>
    {
    }
}
