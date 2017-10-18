/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：038c8adf-9450-4060-895b-9970eca8a412
 * 创建人：  HZWNB147
 * 创建时间：2017/10/18 17:03:35
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
    public class Pagination
    {
        /// <summary>
        /// 每页行数
        /// </summary>
        public int rows { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string sidx { get; set; }
        /// <summary>
        /// 排序类型
        /// </summary>
        public string sord { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int records { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int total
        {
            get
            {
                if (records > 0)
                {
                    return records % this.rows == 0 ? records / this.rows : records / this.rows + 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
