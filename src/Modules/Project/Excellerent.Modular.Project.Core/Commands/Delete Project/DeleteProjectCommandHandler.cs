using AutoMapper;
using Excellerent.Modular.Project.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Project.Core.Commands.Delete_Project
{
    internal class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Response<Guid>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public DeleteProjectCommandHandler(IProjectRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<Guid>> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var projectToDelete = await _repository.GetById(request.Request.ProjectId);
            if (projectToDelete == null)
            {
                return Response<Guid>.IsError(new Exception(request.Request.ProjectId.ToString() + "does not exist"));
            }

            var result = _repository.Delete(projectToDelete);

            return Response<Guid>.IsSuccessful(projectToDelete.Guid);
        }
    }
}
