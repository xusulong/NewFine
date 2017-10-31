/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：a797edec-acef-403d-9c52-b081266806df
 * 创建人：  HZWNB147
 * 创建时间：2017/10/31 14:06:56
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFine.Utils;

namespace NewFine.Entity
{
    public static class TreeSelect
    {
        public static string ThreeSelectJson(this List<TreeSelectModel> data)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            sb.Append(TreeSelectJson(data,"0",""));
            sb.Append("]");
            return sb.ToString();
        }

        private static string TreeSelectJson(List<TreeSelectModel> data, string parentId, string blank)
        {
            StringBuilder sb = new StringBuilder();
            var ChildNodeList = data.FindAll(t => t.parentId == parentId);
            var tabline = "";
            if (parentId != "0")
            {
                tabline = " ";
            }
            if (ChildNodeList.Count > 0)
            {
                tabline += blank;
            }
            foreach (TreeSelectModel entiry in ChildNodeList)
            {
                entiry.text += tabline;
                string strJson = entiry.ToJson();
                sb.Append(strJson);
                sb.Append(TreeSelectJson(data,entiry.id,tabline));
            }
            return sb.ToString().Replace("}{", "},{");
        }
    }
}
