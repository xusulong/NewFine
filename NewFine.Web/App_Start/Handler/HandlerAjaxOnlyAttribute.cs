using System;
using System.Reflection;
using System.Web.Mvc;
namespace NewFine.Web
{
    [AttributeUsage(AttributeTargets.Method)]
    
    public class HandlerAjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        public bool Ignore { get; set; }
        /// <summary>
        /// 该特性验证是否是Ajax请求，用于限制API仅允许ajax请求访问
        /// </summary>
        public HandlerAjaxOnlyAttribute()
        {
            Ignore = Ignore;
        }
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            if (Ignore)
                return true;
            return controllerContext.RequestContext.HttpContext.Request.IsAjaxRequest();
            throw new NotImplementedException();
        }
    }
}