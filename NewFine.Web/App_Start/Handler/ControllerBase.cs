using NewFine.Utils;
using System.Web.Mvc;

namespace NewFine.Web.App_Start.Handler
{
    [HandlerLogin]
      public abstract class ControllerBase : Controller
    { 
        public Log FileLog
        {
            get { return LogFactory.GetLogger(this.GetType().ToString()); }
        }
        [HttpGet]
        [handlerau]
    }
}