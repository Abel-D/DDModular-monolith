using AutoMapper;
using Excellerent.Modular.Client.Core;
using Excellerent.Modular.Client.Core.Commands.AddClient;
using Excellerent.Modular.Client.Core.Contracts;
using Excellerent.Modular.Shared.Application;
using Excellerent.Modular.Shared.Application.Helpers;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Modular.Tests.UnitTest.Client.Handlers
{
    public class AddClientHandlerTests
    {
        private Mock<IClientRepository> mockRepo=TestSetUp.GetMockRepository();
        private Mock<IMediator> mockMediator = new Mock<IMediator>();
        private Mock<IMapper> mockMapper = new Mock<IMapper>();
        private Excellerent.Modular.Client.Core.Client client = new Excellerent.Modular.Client.Core.Client
        {
            Guid = Guid.NewGuid(),
            Name = "Unit test ",
            Description = "for test purpose"
        };

        public AddClientHandlerTests()
        {
        }
        [Fact]
        public async void AddClientCommandHandler_Should_Add_Client()
        {
            //Arrange
            var request = new AddClientRequest {
                Name = "Unit test ",
                Description = "for test purpose"
                };

            var addClientCommand = new AddClientCommand(request);

            var sut = new AddClientCommandHandler(mockRepo.Object,mockMapper.Object);
            //act
            var result = await sut.Handle(addClientCommand,CancellationToken.None);

            //Assert
            Assert.True(TestSetUp.Clients.Count == 3);
    }
        public async void AddClientCommandHandler_Should_Return_Correct_Type()
        {
            //Arrange
            var request = new AddClientRequest
            {
                Name = "Unit test ",
                Description = "for test purpose"
            };

            var addClientCommand = new AddClientCommand(request);

            var sut = new AddClientCommandHandler(mockRepo.Object, mockMapper.Object);
            //act
            var result = await sut.Handle(addClientCommand, CancellationToken.None);
            //Assert
            Assert.IsAssignableFrom<Response<Guid>>(result);
            Assert.IsType<Guid>(result.t);
        }
    }
}
