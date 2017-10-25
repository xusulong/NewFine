/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：7959662f-ade4-4409-b6f2-8bad1fe78bef
 * 创建人：  HZWNB147
 * 创建时间：2017/10/25 9:05:08
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
using System.Data.Entity.ModelConfiguration;
namespace NewFine.Mapping
{
    public class RoleAuthorizeMap : EntityTypeConfiguration<RoleAuthorizeEntity>
    {
        public RoleAuthorizeMap()
        {
            this.ToTable("Sys_RoleAuthorize");
            this.HasKey(t => t.F_Id);
        }
    }
}
