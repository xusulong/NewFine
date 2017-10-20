/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：04966ca1-d589-4849-8039-575a578089fa
 * 创建人：  HZWNB147
 * 创建时间：2017/10/20 8:50:59
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
    /// <summary>
    /// 自定义API消息
    /// </summary>
    public class AjaxResult
    {
        public object stste { get; set; }
        public string message { get; set; }
        public object data { get; set; } 
    }
    /// <summary>
    /// 表示 ajax 操作结果类型的枚举
    /// </summary>
    public enum ResultType
    {
        info,
        success,
        warning,
        error
    }
}
