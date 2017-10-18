/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：6bf72049-db2b-42c8-a2e0-10dfb69dc78b
 * 创建人：  HZWNB147
 * 创建时间：2017/10/18 14:12:12
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFine.Utils
{
    using System.Configuration;
    public class Configs
    {
        /// <summary>
        /// 根据Key取appsetting中的Value值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString().Trim();
        }
    }
}
