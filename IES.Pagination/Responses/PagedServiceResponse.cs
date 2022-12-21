using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES.Kairos.Pagination
{
    public class PagedServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public Uri? FirstPage { get; set; }
        public Uri? LastPage { get; set; }
        public int TotalPages { get; set; }
        public Uri? NextPage { get; set; }
        public Uri? PreviousPage { get; set; }


        public Boolean Success { get; set; }
        public String? Message { get; set; }
        public T Data { get; set; }
        public int RecordCount { get; set; }

        public PagedServiceResponse(T data, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Data = data;
            this.Message = null;
            this.Success = true;

        }
    }
}
