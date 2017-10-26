using System.Web;
using System.Web.Mvc;

namespace NewFine.Web
{
    //自定义过滤器
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandlerErrorAttribute());
        }
    }
}
