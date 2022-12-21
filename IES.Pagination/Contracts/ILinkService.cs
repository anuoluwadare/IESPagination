using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES.Kairos.Pagination
{
    public interface ILinkService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
