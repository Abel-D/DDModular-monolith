using AutoMapper;
using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Queries.GetProjectById
{
    internal class GetProjectByIdQueryHandler : IRequestHandler<GetProjectByIdQuery, Response<Project>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public GetProjectByIdQueryHandler(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<Project>> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = await _repository.GetById(request.Request.ProjectId);
            if(project == null)
            {
                return Response<Project>.IsError(new Exception(request.Request.ProjectId + "does not exist"));
            }

            return Response<Project>.IsSuccessful(_mapper.Map<Project>(project));
        }
    }
}
