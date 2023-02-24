namespace Excellerent.Standard.Advanced.Shared.Application
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
