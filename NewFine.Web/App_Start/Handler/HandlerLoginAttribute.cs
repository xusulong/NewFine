using System.Web.Mvc;
using NewFine.Entity;
using NewFine.Utils;
namespace NewFine.Web
{
    public class HandlerLoginAttribute : AuthorizeAttribute
    {
        public bool Ignore = true;
        public HandlerLoginAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }
        /// <summary>
        /// 判断当前是否登录，未登录跳转到登陆页
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Ignore == false)
            {
                return;
            }
            if (OperatorProvider.Provider.GetCurrent() == null)
            {
                WebHelper.WriteCookie("newfine_log_error","overdue");
                filterContext.HttpContext.Response.Write("<script>top.location.href='/Login/Index';</script>");
                return;
            }
        }
    }
}