/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：8ca7dc3f-aa88-46b3-8163-c83ff24c72e8
 * 创建人：  HZWNB147
 * 创建时间：2017/10/23 9:57:06
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
using System.Data.Entity.ModelConfiguration;
namespace NewFine.Mapping
{
    public class LogMap : EntityTypeConfiguration<LogEntity>
    {
        public LogMap()
        {
            this.ToTable("Sys_Log");
            this.HasKey(t => t.F_Id);
        }
    }
}
