using AutoMapper;
using Excellerent.Standard.Advanced.Project.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Project.Core.Commands.Add_Project
{
    internal class AddProjectCommandHandler : IRequestHandler<AddProjectCommand, Response<Guid>>
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public AddProjectCommandHandler(IProjectRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<Guid>> Handle(AddProjectCommand request, CancellationToken cancellationToken)
        {
            ProjectEntity project = new ProjectEntity
            {
                Name = request.Request.Name,
                ClientId = request.Request.ClientId,
                Description = request.Request.Description
            };
            var result = await _repository.Add(project);

            return Response<Guid>.IsSuccessful(result.Guid);
        }
    }
}
