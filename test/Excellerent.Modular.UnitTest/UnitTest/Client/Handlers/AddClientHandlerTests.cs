using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Excellerent.Standard.Advanced.UnitTest.Client.Handlers
{
    public class AddClientHandlerTests
    {
        private Mock<IClientRepository> mockRepo;
        private Mock<IMediator> mockMediator = new Mock<IMediator>();
        private Mock<IMapper> mockMapper = new Mock<IMapper>();
        private List<ClientEntity> clients = new List<ClientEntity>
            {
                new ClientEntity
                {
                    Guid =new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                    Name = "Test 1",
                    Description ="Test CLient 1"
                }
            };
        public AddClientHandlerTests()
        {
            clients = new List<ClientEntity>
            {
                new ClientEntity
                {
                    Guid =new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                    Name = "Test 1",
                    Description ="Test CLient 1"
                }
            };
        }
        [Fact]
        public async void AddClientCommandHandler_Should_Add_Client()
        {
            //Arrange
            Excellerent.Standard.Advanced.Client.Core.Client client = new Excellerent.Standard.Advanced.Client.Core.Client
            {
                Guid = Guid.NewGuid(),
                Name = "Unit test ",
                Description = "for test purpose"
            };
            var request = new AddClientRequest("Unit test ", "for test purpose");

            var addClientCommand=new AddClientCommand(request);

            var sut = new AddClientCommandHandler(mockRepo.Object,mockMapper.Object);
            mockRepo.Setup(r => r.Add(It.IsAny<ClientEntity>())).ReturnsAsync((ClientEntity client) =>
            {
                clients.Add(mockMapper.Object.Map<ClientEntity>(client));
                return client;

            });
            //act
            var result = await sut.Handle(addClientCommand,CancellationToken.None);

            //Assert
            Assert.IsType<Guid>(result);
            Assert.IsAssignableFrom<Response<Guid>>(result);

        }


        
    }
}
