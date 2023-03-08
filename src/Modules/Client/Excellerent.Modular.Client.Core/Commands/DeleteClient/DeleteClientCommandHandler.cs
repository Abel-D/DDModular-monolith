using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using MediatR;

namespace Excellerent.Modular.Client.Core.Commands.DeleteClient
{
    internal class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, Response<Guid>>
    {
        private readonly IClientRepository _repository;

        public DeleteClientCommandHandler(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response<Guid>> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var clientToDelete = await _repository.GetById(request.Request.ClientId);
            if (clientToDelete == null)
            {
                return Response<Guid>.IsError(new NullReferenceException(request.Request.ClientId.ToString()));
            }
            await _repository.Delete(clientToDelete);

            return Response<Guid>.IsSuccessful(request.Request.ClientId);

        }
    }
}
