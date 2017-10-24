/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：2bf435a0-aa1b-440a-b6f4-82d4d6c5a6cc
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 14:37:53
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
using System.Data.Entity.ModelConfiguration;
namespace NewFine.Mapping
{
    public class ItemsDetailMap: EntityTypeConfiguration<ItemsDetailEntity>
    {
        public ItemsDetailMap()
        {
            this.ToTable("Sys_ItemDetail");
            this.HasKey(t => t.F_Id);
        }
    }
}
