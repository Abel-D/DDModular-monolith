using AutoMapper;
using Excellerent.Modular.Project.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using Excellerent.Modular.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Modular.Project.Core.Queries.GetProjects
{
    public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, Response<PagedList<Project>>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public GetProjectsQueryHandler(IProjectRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<Response<PagedList<Project>>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(request.Request.PaginationParameters);
            List<Project> projects = new List<Project>();

            foreach(var res in result)
            {
                Project project = _mapper.Map<Project>(res);
                projects.Add(project);
            }

            return Response<PagedList<Project>>.IsSuccessful(PagedList<Project>.ToPagedList(projects,request.Request.PaginationParameters.PageNumber,request.Request.PaginationParameters.PageSize));
        }
    }


}
