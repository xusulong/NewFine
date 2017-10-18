/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：a3237390-ae93-49ab-8192-84fc9df9e79f
 * 创建人：  HZWNB147
 * 创建时间：2017/10/18 11:25:22
 * 描述：
 * 
 * 
 ************************************************************************************/

namespace NewFine.Utils
{
    using System.Web.Security;
    public  class Md5
    {
        public static string md5(string str, int code)
        {
            string strEncrypt = string.Empty;
            if (code == 16)
            {
                strEncrypt = FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").Substring(8, 16);
            }
            if (code == 32)
            {
                strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
            }
            return strEncrypt;
        }
    }
}
