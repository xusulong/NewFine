/************************************************************************************
 * Copyright (c) 2017 China All Rights Reserved.
 * CLR版本： 4.0.30319.42000
 * 机器名称：HZWNB147-PC
 * 唯一标识：3312d9bf-a916-42b6-8901-78c8913851dd
 * 创建人：  HZWNB147
 * 创建时间：2017/11/8 10:12:43
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
using NewFine.Data;

namespace NewFine.Repository
{ 
    /// <summary>
    /// 仓库实现，通过继承，获得动作执行能力
    /// </summary>
    public class DailyPlanRepository :RepositoryBase<DailyPlanEntity>, IDailyPlanRepository
    {

    }
}
