namespace Excellerent.Standard.Advanced.Shared.Api.DTO
{
    public class Request<T>
    {
        public Request(T t)
        {
            data = t;
        }
        public T data { get; set; }
    }
}
