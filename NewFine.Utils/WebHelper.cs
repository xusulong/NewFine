/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：32a54a68-1498-4b8f-a57a-b2f9904bab66
 * 创建人：  HZWNB147
 * 创建时间：2017/10/18 11:04:27
 * 描述：
 * 
 * 
 ************************************************************************************/

namespace NewFine.Utils
{
    using System;
    using System.Web;
    public class WebHelper
    {

        #region Cokie操作

        /// <summary>
        /// 写Cookie值
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="StrValue"></param>
        public static void WriteCookie(string strName, string StrValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = StrValue;
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写入cookie的值，过期时间设为expires分钟后
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strValue"></param>
        /// <param name="expires"></param>
        public static void WriteCookie(string strName,string strValue,int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = strValue;
            cookie.Expires = DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 读Cookie值
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static string GetCookie(string strName)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
            {
                return HttpContext.Current.Request.Cookies[strName].Value.ToString();
            }
            return "";
        }

        /// <summary>
        /// 删除Cookie对象
        /// </summary>
        /// <param name="CookiesName"></param>
        public static void RemoveCookie(string CookiesName)
        {
            HttpCookie objCookie = new HttpCookie(CookiesName.Trim());
            objCookie.Expires = DateTime.Now.AddYears(-5);
            HttpContext.Current.Response.Cookies.Add(objCookie);
        }
        #endregion
        #region Session操作

        /// <summary>
        /// 写Session值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void WriteSession(string key, string value)
        {
            WriteSession<string>(key, value);
        }
        /// <summary>
        /// 写Session值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void WriteSession<T>(string key, T value)
        {
            if (key.IsEmpty())
                return;
            HttpContext.Current.Session[key] = value;
        }

        /// <summary>
        /// 读取session的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSession(string key)
        {
            if (key.IsEmpty())
                return string.Empty;
            return HttpContext.Current.Session[key] as string ;
        }
        /// <summary>
        /// 删除指定Session
        /// </summary>
        /// <param name="key">Session的键名</param>
        public static void RemoveSession(string key)
        {
            if (key.IsEmpty())
                return;
            HttpContext.Current.Session.Contents.Remove(key);
        }
        #endregion
    }
}
