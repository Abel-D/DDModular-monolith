using Excellerent.Standard.Advanced.Client.Api;
using Excellerent.Standard.Advanced.Client.Core.Commands.AddClient;
using Excellerent.Standard.Advanced.Client.Core.Queries.GetClients;
using Excellerent.Standard.Advanced.Shared.Infrastructure;
using Excellerent.Standard.Advanced.Shared.Infrastructure.Contracts.Command;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddClientModule();
builder.Services.AddSharedModule();
//builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(AddClientCommand).Assembly,
    typeof(AddClientCommandHandler).Assembly,
    typeof(GetClientsQuery).Assembly,
    typeof(GetClientsQueryHandler).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
