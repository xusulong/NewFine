/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：a5dffcc2-9ff5-4d4e-bd7c-5fae1e237fd7
 * 创建人：  HZWNB147
 * 创建时间：2017/10/24 15:36:29
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using NewFine.Entity;

namespace NewFine.Mapping
{
    public class OrganizeMap:EntityTypeConfiguration<OrganizeEntity>
    {
        public OrganizeMap()
        {
            this.ToTable("Sys_Organize");
            this.HasKey(t => t.F_Id);
        }
    }
}
