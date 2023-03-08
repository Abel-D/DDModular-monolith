namespace Excellerent.Modular.Client.Core.Commands.UpdateClient
{
    public class UpdateClientRequest
    {
        public UpdateClientRequest()
        {

        }
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
