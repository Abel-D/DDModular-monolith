using AutoMapper;
using Excellerent.Modular.Client.Core.Commands.AddClient;
using Excellerent.Modular.Client.Core.Commands.UpdateClient;

namespace Excellerent.Modular.Client.Core
{
    internal class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientEntity>();
            CreateMap<AddClientRequest, Client>();
            CreateMap<UpdateClientRequest, Client>();
            CreateMap<ClientEntity, Client>();
        }
    }
}
