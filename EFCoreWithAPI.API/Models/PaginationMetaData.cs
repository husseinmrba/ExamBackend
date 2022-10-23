namespace EFCoreWithAPI.API.Models
{
    public class PaginationMetaData
    {
        public PaginationMetaData(int totalItemCount, int pageSize, int currentPage)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int) Math.Ceiling(TotalItemCount / (double) pageSize);
        }

        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}
