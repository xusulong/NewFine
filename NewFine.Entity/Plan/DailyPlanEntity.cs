/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：00d7dbb1-0898-447e-ad0d-d468d952753b
 * 创建人：  HZWNB147
 * 创建时间：2017/11/8 9:48:33
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFine.Entity
{
    /// <summary>
    /// 日常计划实体类
    /// </summary>
    public class DailyPlanEntity: IEntity<DailyPlanEntity>
    {
        /// <summary>
        /// 自增长过主键
        /// </summary>
        public int PlanId { get; set; }
        /// <summary>
        /// 计划标题
        /// </summary>
        public string PlanTitle { get; set; }
        /// <summary>
        /// 计划内容
        /// </summary>
        public string PlanContent { get; set; }
        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime DeadLine { get; set; }
        /// <summary>
        /// 有限级
        /// </summary>
        public int Priority { get; set; }
        /// <summary>
        /// 状态：未开启（-1），进行中（0），暂停（1），完成（2），过期（3）
        /// </summary>
        public int PlanStatus { get; set; }
        /// <summary>
        /// 分类：0（学习、读书），1（整理、反思），2（追剧）、3（游戏）、4（琐事）
        /// </summary>
        public int Sort { get; set; }
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 完成后评论
        /// </summary>
        public string FinishRemark { get; set; }
    }
}
