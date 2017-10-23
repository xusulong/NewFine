/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：caf03d17-4588-44bf-8d74-cad028989dab
 * 创建人：  HZWNB147
 * 创建时间：2017/10/23 10:02:19
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
using System.Data.Entity.ModelConfiguration;

namespace NewFine.Mapping
{
    public class UserLogOnMap : EntityTypeConfiguration<UserLogOnEntity>
    {
        public UserLogOnMap()
        {
            this.ToTable("Sys_UserLogOn");
            this.HasKey(t => t.F_Id);
        }
    }
}
