using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES.Kairos.Pagination
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddKairosPagination(this IServiceCollection services)
        {
            return services.AddSingleton<ILinkService>(o =>
            {
                var accessor = o.GetRequiredService<IHttpContextAccessor>();
                var request = accessor.HttpContext.Request;
                var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                return new LinkService(uri);
            });
        }
    }
}
