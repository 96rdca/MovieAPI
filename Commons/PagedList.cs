using System;
namespace Commons
{
	public class PagedList<T>
	{
        public T Data { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }

        public PagedList(T data, int totalRecords ,int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalRecords = totalRecords;
            this.TotalPages = Convert.ToInt32(Math.Ceiling((double)totalRecords / (double)pageSize));
            this.Data = data;
        }
    }
}

