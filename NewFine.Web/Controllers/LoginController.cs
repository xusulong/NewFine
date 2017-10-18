using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewFine.Utils;
using NewFine.Entity;
using NewFine.Application;

namespace NewFine.Web.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// 登录页面的验证码。加密存入session
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAuthCode()
        {
            return File(new VerifyCode().GetVerifyCode(), @"image/Gif");
        }
        public ActionResult CheckLogin(string username,string password,string code)
        { 
            LogEntity logEntity = new LogEntity();
            logEntity.F_ModuleName = "系统登录";
            logEntity.F_Type = DbLogType.Login.ToString();
            try
            {
                if (Session["NewFine@2017"].IsEmpty() || Md5.md5(code.ToLower(), 16) != Session["newfine_session_verifycode"].ToString())
                {
                    throw new Exception("验证码错误，请重新输入");
                }
                UserEntity userEntity = new UserApp().

            }
        }

    }
}