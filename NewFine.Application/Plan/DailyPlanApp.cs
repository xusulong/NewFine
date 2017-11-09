/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：c878a4ab-1797-4ab8-8e60-357a14ae7982
 * 创建人：  HZWNB147
 * 创建时间：2017/11/8 10:20:54
 * 描述：
 * 
 * 
 ************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFine.Entity;
using NewFine.Repository;
using NewFine.Utils;
using NewFine.Data;

namespace NewFine.Application
{
    /// <summary>
    /// 实体类通过继承基类仓库获得动作能力，在此处完成业务操作
    /// </summary>
    public class DailyPlanApp
    {
        private IDailyPlanRepository service = new DailyPlanRepository();

        public List<DailyPlanEntity> GetList(string title = "")
        {
            var expression = ExtLinq.True<DailyPlanEntity>();
            if (!string.IsNullOrEmpty(title))
            {
                expression = expression.And(t => t.PlanTitle.Contains(title));
            }
            return service.IQueryable(expression).OrderBy(t => t.AddTime).ToList();
        }
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<DailyPlanEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<DailyPlanEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.PlanTitle.Contains(keyword));
                expression = expression.Or(t => t.PlanContent.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public DailyPlanEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(int planId)
        {
            service.Delete(t => t.PlanId == planId);
        }
        public void SubmitForm(DailyPlanEntity roleEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {

                service.Update(roleEntity);
            }
            else
            {
                roleEntity.AddTime = DateTime.Now;
                roleEntity.DeadLine = DateTime.Now.AddDays(1);
                service.Insert(roleEntity);
            }

        }
    }
}
