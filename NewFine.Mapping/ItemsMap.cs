/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：59b621d4-57f8-47f9-bb9b-9df50a49263f
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 14:56:31
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
using System.Data.Entity.ModelConfiguration;

namespace NewFine.Mapping
{
    public class ItemsMap : EntityTypeConfiguration<ItemsEntity>
    {
        public ItemsMap()
        {
            this.ToTable("Sys_Items");
            this.HasKey(t => t.F_Id);
        }
    }
}
