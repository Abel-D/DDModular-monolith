using AutoMapper;
using Excellerent.Standard.Advanced.Client.Core;
using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Contracts;
using Excellerent.Standard.Advanced.Shared.Application;
using Excellerent.Standard.Advanced.Shared.Application.Helpers;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellerent.Standard.Advanced.Tests.UnitTest.Client.Handlers
{
    public class AddClientHandlerTests
    {
        private Mock<IClientRepository> mockRepo=TestSetUp.GetMockRepository();
        private Mock<IMediator> mockMediator = new Mock<IMediator>();
        private Mock<IMapper> mockMapper = new Mock<IMapper>();
        private Excellerent.Standard.Advanced.Client.Core.Client client = new Excellerent.Standard.Advanced.Client.Core.Client
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
            var request = new AddClientRequest("Unit test ", "for test purpose");

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
            var request = new AddClientRequest("Unit test ", "for test purpose");

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
