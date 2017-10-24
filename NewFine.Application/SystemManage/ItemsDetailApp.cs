/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：b2d0222c-afde-40c5-8c26-5348a276c33e
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 10:30:27
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFine.Entity;
using NewFine.Repository;
using NewFine.Utils;


namespace NewFine.Application
{
    public class ItemDetailApp
    {
        private IItemsDetailRepository service = new ItemsDetailRepository();
        public List<ItemsDetailEntity> GetList(string itemId = " ", string keyword = "")
        {
            var expression = ExtLinq.True<ItemsDetailEntity>();
            if (string.IsNullOrEmpty(itemId))
            {
                expression = expression.And(t => t.F_ItemId == itemId);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_ItemName.Contains(keyword));
                expression = expression.Or(t => t.F_ItemCode.Contains(keyword)); 
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }

    }
}
