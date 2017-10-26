using System.Web.Mvc;
using NewFine.Utils;

namespace NewFine.Web
{
    /// <summary>
    /// 在cshtml中出现错误，则触发在这个Error处理。返回状态码200和相关错误信息
    /// </summary>
    public class HandlerErrorAttribute: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
            context.ExceptionHandled = true;
            context.HttpContext.Response.StatusCode = 200;
            context.Result = new ContentResult { Content = new AjaxResult { state = ResultType.error.ToString(), message = context.Exception.Message }.ToJson() };
        }
        private void WriteLog(ExceptionContext context)
        {
            if (context == null)
                return;
            var log = LogFactory.GetLogger(context.Controller.ToString());
            log.Error(context.Exception);
        }
    }
}