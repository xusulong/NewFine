/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：a876988b-d1fb-4edb-ba8e-456c627f02a9
 * 创建人：  HZWNB147
 * 创建时间：2017/10/25 9:49:22
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
 using System.Data.Entity.ModelConfiguration;

namespace NewFine.Mapping
{
    public class ModuleButtonMap : EntityTypeConfiguration<ModuleButtonEntity>
    {
        public ModuleButtonMap()
        {
            this.ToTable("Sys_ModuleButton");
            this.HasKey(t => t.F_Id);
        }
    }
}
