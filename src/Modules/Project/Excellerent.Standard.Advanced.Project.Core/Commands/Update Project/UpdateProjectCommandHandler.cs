using AutoMapper;
using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Update_Project
{
    internal class UpdateProjectCommandHandler:IRequestHandler<UpdateProjectCommand,Response<Guid>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProjectCommandHandler(IProjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<Guid>> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var projectToUpdate = await _repository.GetById(request.Request.ProjectId);

            if (projectToUpdate == null)
            {
                return Response<Guid>.IsError(new Exception(request.Request.ProjectId.ToString() + "does not exist"));
            }
            ProjectEntity project = new ProjectEntity
            {
                Guid = request.Request.ProjectId,
                Name = request.Request.Name,
                ClientId = request.Request.ClientId,
                Description = request.Request.Description,
            };
            var result = await _repository.Update(project);
            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
