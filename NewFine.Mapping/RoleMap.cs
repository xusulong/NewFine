/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：1f3da245-86cc-4d92-bab6-cb53e0eb484b
 * 创建人：  HZWNB147
 * 创建时间：2017/10/25 10:28:38
 * 描述：
 * 
 * 
 ************************************************************************************/
using System.Data.Entity.ModelConfiguration;
using NewFine.Entity;

namespace NewFine.Mapping
{
    public class RoleMap : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMap()
        {
            this.ToTable("Sys_Role");
            this.HasKey(t => t.F_Id);
        }
    }
}
