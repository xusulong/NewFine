/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：418a9810-7073-4423-87c9-3615977519bb
 * 创建人：  HZWNB147
 * 创建时间：2017/10/31 13:58:07
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFine.Entity
{
    public class TreeSelectModel
    {
        public string id { get; set; }
        public string next { get; set; }
        public string text { get; set; }
        public string parentId { get; set; }
        public object data { get; set; }
    }
}
