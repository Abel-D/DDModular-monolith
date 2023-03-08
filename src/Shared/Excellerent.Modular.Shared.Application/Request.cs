namespace Excellerent.Modular.Shared.Application
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
