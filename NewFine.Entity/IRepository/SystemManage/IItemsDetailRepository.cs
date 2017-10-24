/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：bb6e34fd-13ab-4ec0-a249-bf29cc5a2350
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 11:19:57
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Data;
using System.Collections.Generic;

namespace NewFine.Entity
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
