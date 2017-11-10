using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewFine.Data;
using NewFine.Application;
using NewFine.Utils;
using NewFine.Entity;
namespace NewFine.Web.Controllers
{
    public class DailyPlanController : ControllerBase
    {
        DailyPlanApp dailyPlanApp = new DailyPlanApp();
        /// <summary>
        /// 关键字搜索结果，分页返回
        /// </summary>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = dailyPlanApp.GetList(pagination, keyword),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(DailyPlanEntity userEntity,string keyValue)
        {
            dailyPlanApp.SubmitForm(userEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(int keyValue)
        {
            var data = dailyPlanApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
    }
}