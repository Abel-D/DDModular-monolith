namespace Excellerent.Standard.Advanced.Shared.Application.Helpers
{
    public class IEnumerable<T> : List<T>
    {
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public List<T> Items { get; private set; }


        public IEnumerable<T> list { get; private set; }
        public IEnumerable(List<T> t, int pageSize, int count, int pageIndex)
        {
            PageSize = pageSize;
            TotalCount = count;
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            Items = t;
            AddRange(t);
        }
        public static IEnumerable<T> ToPagedList(System.Collections.Generic.IEnumerable<T> src, int pageIndex, int pageSize)
        {

            var count = src.Count();
            var items = src.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new IEnumerable<T>(items, pageSize, count, pageIndex);
        }
    }
}
