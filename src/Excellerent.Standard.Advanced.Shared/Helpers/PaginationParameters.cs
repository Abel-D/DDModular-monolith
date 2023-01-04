namespace Excellerent.Standard.Advanced.Shared.Helpers
{
    public class PaginationParameters
    {
        const int max_pagesize = 50;
        public int PageNumber { get; set; } = 1;
        private int _PageSize = 10;
        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = value > max_pagesize ? max_pagesize : value;
            }
        }


    }
}
