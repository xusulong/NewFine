/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：4c6be04a-12ff-4295-ba2c-40530ef8c2d7
 * 创建人：  HZWNB147
 * 创建时间：2017/11/8 10:02:18
 * 描述：
 * 
 * 
 ************************************************************************************/
using NewFine.Entity;
using System.Data.Entity.ModelConfiguration;

namespace NewFine.Mapping
{
    /// <summary>
    /// 通过Mapping，使实体类与数据库上下文建立联系
    /// </summary>
    public class DailyPlanMapping: EntityTypeConfiguration<DailyPlanEntity>
    {

        public DailyPlanMapping()
        {
            this.ToTable("TB_DailyPlan");
            this.HasKey(t => t.PlanId);
        }
    }
}
