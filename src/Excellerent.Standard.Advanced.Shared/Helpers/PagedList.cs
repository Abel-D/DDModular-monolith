namespace Excellerent.Standard.Advanced.Shared.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public List<T> Items { get; private set; }


        public PagedList<T> list { get; private set; }
        public PagedList(List<T> t, int pageSize, int count, int pageIndex)
        {
            PageSize = pageSize;
            TotalCount = count;
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            Items = t;
            AddRange(t);
        }
        public static PagedList<T> ToPagedList(IEnumerable<T> src, int pageIndex, int pageSize)
        {

            var count = src.Count();
            var items = src.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, pageSize, count, pageIndex);
        }
    }
}
