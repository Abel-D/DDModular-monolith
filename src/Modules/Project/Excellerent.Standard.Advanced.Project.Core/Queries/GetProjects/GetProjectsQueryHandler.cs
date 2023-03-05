using AutoMapper;
using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using MediatR;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjects
{
    internal class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, Response<Shared.Application.Helpers.IEnumerable<Project>>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public GetProjectsQueryHandler(IProjectRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<Response<Shared.Application.Helpers.IEnumerable<Project>>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            var projects = await _repository.GetAllAsync(request.Request.PaginationParameters);
            List<Project> result = new List<Project>();

            foreach(var project in projects)
            {
               result.Add(_mapper.Map<Project>(project));
            }

            return Response<Shared.Application.Helpers.IEnumerable<Project>>.IsSuccessful((Shared.Application.Helpers.IEnumerable<Project>)result);
        }
    }


}
